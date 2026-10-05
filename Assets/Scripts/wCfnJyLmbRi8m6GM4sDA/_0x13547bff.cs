using UnityEngine;

/// The three pulse speeds the player can pick, and the stored choice.
///
/// Both scenes need this table - the menu to preview and label it, the arena to
/// run it - so it lives in one place. The key is a short literal and not a
/// nameof(): a persisted identifier must survive the symbol renaming the release
/// build applies (rule C.1 / obfuscation safety).
public static class _0x13547bff
{
    public static float PulseSpeedMul(int _0xe4963132)
    {
        if (_0xe4963132 == Slow)
        {
            return 0.80f;
        }

        if (_0xe4963132 == Fever)
        {
            return 1.30f;
        }

        return 1.00f;
    }

    public const int Steady = 1;
    public static readonly string BestSavedKeyPrefix = _0x2f12efeb._0x98c9eee7(new byte[9] { 166, 166, 147, 191, 173, 186, 169, 168, 147 }, 204);
    public const int Count = 3;
    public static void RecordRun(int _0x03674651, float _0x4f66571c, int _0x04a38c22)
    {
        if (_0x4f66571c > BestTime(_0x03674651))
        {
            PlayerPrefs.SetFloat(BestTimeKeyPrefix + _0x03674651, _0x4f66571c);
            PlayerPrefs.SetInt(BestSavedKeyPrefix + _0x03674651, _0x04a38c22);
            PlayerPrefs.Save();
        }
    }

    public static readonly string AttemptKey = _0x2f12efeb._0x98c9eee7(new byte[10] { 184, 184, 141, 179, 166, 166, 183, 191, 162, 166 }, 210);
    public static float BestTime(int _0x9ccb71c4)
    {
        return PlayerPrefs.GetFloat(BestTimeKeyPrefix + _0x9ccb71c4, 0f);
    }

    public static void SetCurrent(int _0xa6677bc7)
    {
        PlayerPrefs.SetInt(ModeKey, Mathf.Clamp(_0xa6677bc7, 0, Count - 1));
        PlayerPrefs.Save();
    }

    public const int Slow = 0;
    public static int Current()
    {
        return Mathf.Clamp(PlayerPrefs.GetInt(ModeKey, Steady), 0, Count - 1);
    }

    public static float SpawnIntervalMul(int _0x26e7e70a)
    {
        if (_0x26e7e70a == Slow)
        {
            return 1.20f;
        }

        if (_0x26e7e70a == Fever)
        {
            return 0.78f;
        }

        return 1.00f;
    }

    public static readonly string ModeKey = _0x2f12efeb._0x98c9eee7(new byte[7] { 157, 157, 168, 154, 152, 147, 146 }, 247);
    public const int Fever = 2;
    public static readonly string BestTimeKeyPrefix = _0x2f12efeb._0x98c9eee7(new byte[8] { 27, 27, 46, 19, 20, 2, 5, 46 }, 113);
    /// Incremented every time a round starts, so two consecutive attempts at the
    /// same mode get different seeds and therefore a visibly different schedule.
    public static int NextAttempt()
    {
        int _0xb0b32d5a = PlayerPrefs.GetInt(AttemptKey, 0) + 1;
        PlayerPrefs.SetInt(AttemptKey, _0xb0b32d5a);
        PlayerPrefs.Save();
        return _0xb0b32d5a;
    }

    public static int BestSaved(int _0xbe9b0d5c)
    {
        return PlayerPrefs.GetInt(BestSavedKeyPrefix + _0xbe9b0d5c, 0);
    }

    public static string SpeedLabel(int _0x1c595ad0)
    {
        if (_0x1c595ad0 == Slow)
        {
            return _0x2f12efeb._0x98c9eee7(new byte[5] { 60, 34, 52, 60, 84 }, 12);
        }

        if (_0x1c595ad0 == Fever)
        {
            return _0x2f12efeb._0x98c9eee7(new byte[5] { 201, 214, 203, 200, 160 }, 248);
        }

        return _0x2f12efeb._0x98c9eee7(new byte[5] { 31, 0, 30, 30, 118 }, 46);
    }

    public static string Title(int _0x12e1dbd1)
    {
        if (_0x12e1dbd1 == Slow)
        {
            return _0x2f12efeb._0x98c9eee7(new byte[4] { 67, 92, 95, 71 }, 16);
        }

        if (_0x12e1dbd1 == Fever)
        {
            return _0x2f12efeb._0x98c9eee7(new byte[5] { 55, 52, 39, 52, 35 }, 113);
        }

        return _0x2f12efeb._0x98c9eee7(new byte[6] { 108, 107, 122, 126, 123, 102 }, 63);
    }

    /// Clock readout used by the HUD, the record line and the result cards.
    public static string Clock(float _0x3b53ba16)
    {
        int _0x49e928fc = Mathf.Max(0, Mathf.CeilToInt(_0x3b53ba16));
        int _0x15125f9d = _0x49e928fc / 60;
        int _0x5755dcee = _0x49e928fc % 60;
        return _0x15125f9d.ToString(_0x2f12efeb._0x98c9eee7(new byte[2] { 161, 161 }, 145)) + _0x2f12efeb._0x98c9eee7(new byte[1] { 186 }, 128) + _0x5755dcee.ToString(_0x2f12efeb._0x98c9eee7(new byte[2] { 166, 166 }, 150));
    }
}

internal static class _0x2f12efeb
{
    internal static string _0x98c9eee7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}