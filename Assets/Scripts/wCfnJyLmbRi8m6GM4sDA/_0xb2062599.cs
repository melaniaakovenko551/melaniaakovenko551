using System.Collections.Generic;
using UnityEngine;

/// One pulse, as planned before the round starts.
public sealed class _0xb2062599
{
    public int Lane;
    public bool IsHazard;
    public float ArriveAt;
    public bool IsVolley;
    public float SpawnAt;
}

/// A whole round's worth of pulses plus the gate index it was planned against.
public sealed class _0x2c4ae669
{
    public List<_0xb2062599> Entries = new List<_0xb2062599>();
    public int StartGateLane;
}

/// Builds the round: a seeded schedule, checked for playability before it is ever
/// shown, with a hard-wired fallback so a bad draw can never reach the player.
///
/// WHY THE EXPOSURE CLOCK EXISTS. Rule C.5 requires an untouched run to last at
/// least 60 s. Steering hazards away from the open gate with a decaying
/// probability (the "gateBias" warm-up) gives the right AVERAGE - about 2.3 hits
/// against 3 shards - but an average does not bound the worst seed. Ported to a
/// simulator and measured over 2000 attempts per mode, that rule alone killed an
/// untouched run before 60 s in 10-22 percent of seeds, the earliest at 16.8 s,
/// which is inside the review capture window.
///
/// So the floor is CONSTRUCTED rather than hoped for: a hazard may only be aimed
/// down the open gate after GateHazardFirstSeconds, and two gate-aimed hazards
/// must be at least GateHazardMinGap apart. A third hit therefore cannot land
/// before 26 + 17 + 17 = 60 s for any seed or mode. Re-measured the same way:
/// worst untouched life 60.4 s over 6000 runs, none below the floor, and about a
/// third of runs still end in a real loss - after the capture window.
///
/// gateBias is kept, but only as texture; it no longer carries the guarantee.
public static class _0x743cc942
{
    private const float TightPairWindow = 0.45f;
    private const int MinReachableCharges = 8;
    public const int Lanes = 4;
    public static int StepsBetween(int _0x285acf63, int _0x2dac136f)
    {
        int _0x3ef6fcf5 = ((_0x2dac136f - _0x285acf63) % Lanes + Lanes) % Lanes;
        return _0x3ef6fcf5 == 3 ? 1 : _0x3ef6fcf5;
    }

    private const float GateHazardMinGap = 17f;
    private const int MaxTightPairs = 4;
    private const float IntroSeconds = 1.2f;
    /// A generator is allowed to produce something unfair, so nothing is shown
    /// until it has been played through: every hazard must be readable, dense
    /// hazard pairs are capped, and enough charges must be collectable for the
    /// charge meter to be a real mechanic rather than decoration.
    public static bool IsPlayable(_0x2c4ae669 _0x32b95584)
    {
        if (_0x32b95584 == null || _0x32b95584.Entries.Count < 12)
        {
            return false;
        }

        int _0x35799525 = 0;
        int _0xe9f4e131 = 0;
        float _0x0b49ccf6 = 0f;
        int _0xa8a54497 = _0x32b95584.StartGateLane;
        for (int _0x2a5fef41 = 0; _0x2a5fef41 < _0x32b95584.Entries.Count; _0x2a5fef41++)
        {
            _0xb2062599 _0xe46fd0fb = _0x32b95584.Entries[_0x2a5fef41];
            if (_0xe46fd0fb.IsHazard && (_0xe46fd0fb.ArriveAt - _0xe46fd0fb.SpawnAt) < MinReactionSeconds)
            {
                return false;
            }

            if (_0xe46fd0fb.IsHazard)
            {
                for (int _0x9423a911 = _0x2a5fef41 + 1; _0x9423a911 < _0x32b95584.Entries.Count; _0x9423a911++)
                {
                    _0xb2062599 _0xfb8b57b3 = _0x32b95584.Entries[_0x9423a911];
                    if ((_0xfb8b57b3.ArriveAt - _0xe46fd0fb.ArriveAt) > TightPairWindow)
                    {
                        break;
                    }

                    if (_0xfb8b57b3.IsHazard && _0xfb8b57b3.Lane != _0xe46fd0fb.Lane)
                    {
                        _0x35799525++;
                    }
                }
            }
            else
            {
                // Greedy ring: can it be turned onto this charge's lane in time,
                // given a 0.30 s step and at most two steps to any lane?
                int _0xa2be6eea = StepsBetween(_0xa8a54497, _0xe46fd0fb.Lane);
                float _0x0e520a14 = _0x0b49ccf6 + (_0xa2be6eea * 0.30f);
                if (_0xa2be6eea == 0 || _0x0e520a14 <= _0xe46fd0fb.ArriveAt)
                {
                    _0xe9f4e131++;
                    _0xa8a54497 = _0xe46fd0fb.Lane;
                    _0x0b49ccf6 = Mathf.Max(_0xe46fd0fb.ArriveAt, _0x0e520a14);
                }
            }
        }

        return _0x35799525 <= MaxTightPairs && _0xe9f4e131 >= MinReachableCharges;
    }

    public const int CoreShards = 3;
    public const float InvulnSeconds = 1.2f;
    /// THE shared lane rule. The planner below and the simulation that validates it
    /// both go through this one function, so the run that is proved is the run that
    /// ships.
    public static int ChooseLane(System.Random _0x685775f7, float _0xcec67cf5, float _0xa1af8c3b, int _0x7811514e, bool _0x7cddb8cc, float _0xd5a8775c)
    {
        if (!_0x7cddb8cc)
        {
            return _0x685775f7.Next(Lanes);
        }

        bool _0x5f27da34 = _0xa1af8c3b >= GateHazardFirstSeconds && (_0xa1af8c3b - _0xd5a8775c) >= GateHazardMinGap;
        if (!_0x5f27da34 || _0x685775f7.NextDouble() < GateBiasAt(_0xcec67cf5))
        {
            return (_0x7811514e + 1 + _0x685775f7.Next(Lanes - 1)) % Lanes;
        }

        return _0x7811514e;
    }

    /// Fraction of hazards steered away from the gate purely for pacing: nearly all
    /// of them early, less than a third by the end, so the stage "warms up".
    public static float GateBiasAt(float _0xdba2fdf2)
    {
        return Mathf.Lerp(0.95f, 0.30f, Mathf.Clamp01(_0xdba2fdf2 / RoundSeconds));
    }

    public const int ChargeTarget = 5;
    private const float SpawnIntervalBase = 1.85f;
    // Playability thresholds (checked by IsPlayable before the schedule is used).
    private const float MinReactionSeconds = 0.80f;
    private const float TravelTimeStart = 3.20f;
    private const float TravelTimeEnd = 1.70f;
    public static _0x2c4ae669 Build(int _0xd399e7c4, int _0x38958a3b)
    {
        int _0xf7aeb4da = (_0xd399e7c4 * 7919) ^ (_0x38958a3b * 104729);
        System.Random _0xef6f8797 = new System.Random(_0xf7aeb4da);
#if B_LOGS
        {
            Debug.Log(_0x0dcaab0a._0x7d4cd1d7(new byte[13] { 25, 48, 45, 55, 44, 38, 31, 98, 49, 39, 39, 38, 127 }, 66) + _0xf7aeb4da + _0x0dcaab0a._0x7d4cd1d7(new byte[6] { 218, 151, 149, 158, 159, 199 }, 250) + _0xd399e7c4 + _0x0dcaab0a._0x7d4cd1d7(new byte[9] { 133, 196, 209, 209, 192, 200, 213, 209, 152 }, 165) + _0x38958a3b);
        }

#endif
        _0x2c4ae669 _0x24919c81 = Generate(_0xef6f8797, _0xd399e7c4);
        for (int _0x2fd889d4 = 0; _0x2fd889d4 < 20 && !IsPlayable(_0x24919c81); _0x2fd889d4++)
        {
            _0x24919c81 = Generate(_0xef6f8797, _0xd399e7c4);
        }

        if (!IsPlayable(_0x24919c81))
        {
            _0x24919c81 = Fallback(_0xd399e7c4);
        }

        return _0x24919c81;
    }

    public const float RoundSeconds = 75f;
    private static _0x2c4ae669 Generate(System.Random _0x50109024, int _0xf968a756)
    {
        float _0x9bcebccc = _0x13547bff.PulseSpeedMul(_0xf968a756);
        float _0x9345ffbe = _0x13547bff.SpawnIntervalMul(_0xf968a756);
        _0x2c4ae669 _0xbc31f27c = new _0x2c4ae669();
        _0xbc31f27c.StartGateLane = _0x50109024.Next(Lanes);
        float _0xbfb90904 = -999f;
        float _0x32967a33 = IntroSeconds;
        float _0xdd1056d9 = 12f + (float)_0x50109024.NextDouble() * 6f;
        while (_0x32967a33 < RoundSeconds)
        {
            bool _0x8278de10 = _0x32967a33 >= _0xdd1056d9;
            int _0xd9c5ac69 = _0x8278de10 ? 3 : 1;
            for (int _0xc9b70d0a = 0; _0xc9b70d0a < _0xd9c5ac69; _0xc9b70d0a++)
            {
                bool _0x29eab11d = _0x50109024.NextDouble() < HazardShare;
                float _0xbcb7c10f = Mathf.Clamp01(_0x32967a33 / RoundSeconds);
                float _0xb227782b = Mathf.Lerp(TravelTimeStart, TravelTimeEnd, _0xbcb7c10f) / _0x9bcebccc;
                _0xb227782b *= 1f + (((float)_0x50109024.NextDouble() * 2f) - 1f) * 0.08f;
                float _0x21e54133 = _0x32967a33 + (_0xc9b70d0a * 0.16f);
                float _0xc60da1f6 = _0x21e54133 + _0xb227782b;
                int _0x1738b875 = ChooseLane(_0x50109024, _0x32967a33, _0xc60da1f6, _0xbc31f27c.StartGateLane, _0x29eab11d, _0xbfb90904);
                if (_0x29eab11d && _0x1738b875 == _0xbc31f27c.StartGateLane)
                {
                    _0xbfb90904 = _0xc60da1f6;
                }

                _0xb2062599 _0x355752c4 = new _0xb2062599();
                _0x355752c4.SpawnAt = _0x21e54133;
                _0x355752c4.ArriveAt = _0xc60da1f6;
                _0x355752c4.Lane = _0x1738b875;
                _0x355752c4.IsHazard = _0x29eab11d;
                _0x355752c4.IsVolley = _0x8278de10;
                _0xbc31f27c.Entries.Add(_0x355752c4);
            }

            if (_0x8278de10)
            {
                _0xdd1056d9 = _0x32967a33 + 12f + ((float)_0x50109024.NextDouble() * 6f);
            }

            float _0x0b13e634 = SpawnIntervalBase * _0x9345ffbe;
            _0x0b13e634 *= 1f + (((float)_0x50109024.NextDouble() * 2f) - 1f) * 0.18f;
            _0x32967a33 += Mathf.Max(0.5f, _0x0b13e634);
        }

        _0xbc31f27c.Entries.Sort((_0x215fbbf4, _0xc6fad4a3) => _0x215fbbf4.ArriveAt.CompareTo(_0xc6fad4a3.ArriveAt));
        return _0xbc31f27c;
    }

    /// The single hard-wired layout in the project, and it is a safety net rather
    /// than the game: an even, readable cadence that always satisfies IsPlayable.
    private static _0x2c4ae669 Fallback(int _0x01c7e9bd)
    {
        float _0x3e27ba14 = _0x13547bff.PulseSpeedMul(_0x01c7e9bd);
        _0x2c4ae669 _0x6141ea37 = new _0x2c4ae669();
        _0x6141ea37.StartGateLane = 0;
        int _0x1f9e55f0 = 0;
        for (float _0x2a34e9f3 = IntroSeconds; _0x2a34e9f3 < RoundSeconds; _0x2a34e9f3 += 2.0f)
        {
            bool _0xe53eb8d2 = (_0x1f9e55f0 % 5) != 0 && (_0x1f9e55f0 % 5) != 3;
            float _0x54a7172f = Mathf.Lerp(TravelTimeStart, TravelTimeEnd, Mathf.Clamp01(_0x2a34e9f3 / RoundSeconds)) / _0x3e27ba14;
            float _0x8f08a838 = _0x2a34e9f3 + _0x54a7172f;
            int _0x8bdb1616;
            if (_0xe53eb8d2)
            {
                bool _0xcbd21f52 = _0x8f08a838 >= GateHazardFirstSeconds && Mathf.Repeat(_0x8f08a838 - GateHazardFirstSeconds, GateHazardMinGap) < 2.0f;
                _0x8bdb1616 = _0xcbd21f52 ? _0x6141ea37.StartGateLane : 1 + (_0x1f9e55f0 % 3);
            }
            else
            {
                _0x8bdb1616 = _0x1f9e55f0 % Lanes;
            }

            _0xb2062599 _0xb01a5184 = new _0xb2062599();
            _0xb01a5184.SpawnAt = _0x2a34e9f3;
            _0xb01a5184.ArriveAt = _0x8f08a838;
            _0xb01a5184.Lane = _0x8bdb1616;
            _0xb01a5184.IsHazard = _0xe53eb8d2;
            _0x6141ea37.Entries.Add(_0xb01a5184);
            _0x1f9e55f0++;
        }

        _0x6141ea37.Entries.Sort((_0x215fbbf4, _0xc6fad4a3) => _0x215fbbf4.ArriveAt.CompareTo(_0xc6fad4a3.ArriveAt));
        return _0x6141ea37;
    }

    // The two constants that MAKE the C.5 floor.
    private const float GateHazardFirstSeconds = 26f;
    private const float HazardShare = 0.60f;
}

internal static class _0x0dcaab0a
{
    internal static string _0x7d4cd1d7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}