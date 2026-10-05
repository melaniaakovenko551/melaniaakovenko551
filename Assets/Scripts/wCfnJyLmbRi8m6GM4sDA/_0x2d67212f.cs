using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// Plays a prepared schedule: spawns each pulse at its planned moment, dresses it
/// as hazard or charge, and lights the lanes of a volley before it lands.
///
/// It does not decide WHAT comes - PulseScheduleBuilder did that, and did it
/// through a rule that was simulated first. Keeping the decision there is what
/// makes the proved survival floor the shipped one.
public sealed class _0x2d67212f : MonoBehaviour
{
    public void _0xb4f94cb9(_0x2c4ae669 _0xee503973, _0x6b5ddddc _0x376302e0, Transform _0xc43ca3e4, Vector2 _0x29069578, float _0xf17152b2, float _0x0cd54983, float _0x187a3894, List<SpriteRenderer> _0x9b833a37, GameObject _0x97e95544, Sprite _0x2b67d293, Sprite _0xb7fb87f1, System.Action<_0x0c02d024, bool, bool> _0x2c244180)
    {
        this._0x23c14885 = _0x97e95544;
        this._0xcd8b48af = _0x2b67d293;
        this._0x7e76ad2b = _0xb7fb87f1;
        this._0x2ceb7395 = _0xee503973;
        this._0x3437ce48 = _0x376302e0;
        this._0x9e516a23 = _0xc43ca3e4;
        this._0x7d60552e = _0x29069578;
        this._0xab814683 = _0xf17152b2;
        this._0xfe29fce4 = _0x0cd54983;
        this._0x29762ad2 = _0x187a3894;
        this._0x607a3f56 = _0x2c244180;
        this._0x34e37398 = 0;
        this._0xac758559.Clear();
        if (_0x9b833a37 != null)
        {
            this._0xac758559.AddRange(_0x9b833a37);
        }
    }

    public void _0x2612caab(float _0xcff77e7c)
    {
        if (!this._0xcf6adcec || this._0x2ceb7395 == null)
        {
            return;
        }

        while (this._0x34e37398 < this._0x2ceb7395.Entries.Count && this._0x2ceb7395.Entries[this._0x34e37398].SpawnAt <= _0xcff77e7c)
        {
            this._0x1a6a05ca(this._0x2ceb7395.Entries[this._0x34e37398]);
            this._0x34e37398++;
        }

        this._0x827507d0(_0xcff77e7c);
    }

    private int _0x34e37398;
    private System.Action<_0x0c02d024, bool, bool> _0x607a3f56;
    private float _0x29762ad2;
    private const float TelegraphLead = 0.9f;
    public static float LaneAngle(int _0xbf26529c)
    {
        return 90f * _0xbf26529c;
    }

    /// Clears the board when the round ends: anything still travelling fades out
    /// rather than snapping away.
    public void _0x1078ebc4()
    {
        this._0xcf6adcec = false;
        for (int _0x2e358a0b = this._0xfcb213e5.Count - 1; _0x2e358a0b >= 0; _0x2e358a0b--)
        {
            if (this._0xfcb213e5[_0x2e358a0b] != null)
            {
                this._0xfcb213e5[_0x2e358a0b]._0x3be492c2();
            }
        }

        this._0xfcb213e5.Clear();
    }

    private readonly List<_0x0c02d024> _0xfcb213e5 = new List<_0x0c02d024>();
    private Sprite _0xcd8b48af;
    public void _0x20565886(bool _0xec11cb00)
    {
        this._0xcf6adcec = _0xec11cb00;
    }

    // The arena owns every asset reference and hands them down, so there is exactly
    // one place in the game scene where serialized art is wired.
    private GameObject _0x23c14885;
    private bool _0xcf6adcec;
    private float _0xfe29fce4;
    private readonly List<SpriteRenderer> _0xac758559 = new List<SpriteRenderer>();
    private Vector2 _0x7d60552e;
    private _0x6b5ddddc _0x3437ce48;
    /// A volley is announced before it arrives, so a burst is never a surprise the
    /// player could not have read (the fairness half of rule C.5).
    private void _0x827507d0(float _0x6c3d8c49)
    {
        for (int _0x13d91f4e = this._0x34e37398; _0x13d91f4e < this._0x2ceb7395.Entries.Count; _0x13d91f4e++)
        {
            _0xb2062599 _0xcff66238 = this._0x2ceb7395.Entries[_0x13d91f4e];
            if (_0xcff66238.SpawnAt > _0x6c3d8c49 + TelegraphLead)
            {
                break;
            }

            if (!_0xcff66238.IsVolley || _0xcff66238.Lane >= this._0xac758559.Count)
            {
                continue;
            }

            SpriteRenderer _0x1f7e5e64 = this._0xac758559[_0xcff66238.Lane];
            if (_0x1f7e5e64 == null || DOTween.IsTweening(_0x1f7e5e64))
            {
                continue;
            }

            _0x1f7e5e64.DOColor(_0xa341162f.Gold, 0.22f).SetLoops(2, LoopType.Yoyo);
        }
    }

    private Transform _0x9e516a23;
    private Sprite _0x7e76ad2b;
    private _0x2c4ae669 _0x2ceb7395;
    private void _0x6e8bbe4a(_0x0c02d024 _0x12a9cc33, bool _0x36fa74c0, bool _0xcad2991c)
    {
        this._0xfcb213e5.Remove(_0x12a9cc33);
        System.Action<_0x0c02d024, bool, bool> _0x0e8453c8 = this._0x607a3f56;
        if (_0x0e8453c8 != null)
        {
            _0x0e8453c8.Invoke(_0x12a9cc33, _0x36fa74c0, _0xcad2991c);
        }

        if (_0x12a9cc33 != null && _0x12a9cc33.gameObject != null)
        {
            Destroy(_0x12a9cc33.gameObject);
        }
    }

    private void _0x1a6a05ca(_0xb2062599 _0x5f0d8853)
    {
        if (this._0x23c14885 == null || this._0x9e516a23 == null)
        {
            return;
        }

        GameObject _0x843a224e = Instantiate(this._0x23c14885, this._0x9e516a23);
        SpriteRenderer _0x2572d1dd = _0x843a224e.GetComponent<SpriteRenderer>();
        if (_0x2572d1dd != null)
        {
            _0x2572d1dd.sprite = _0x5f0d8853.IsHazard ? this._0xcd8b48af : this._0x7e76ad2b;
            _0x2572d1dd.color = _0x5f0d8853.IsHazard ? _0xa341162f.Crimson : _0xa341162f.Teal;
            // Sliced draw mode makes m_Size authoritative, so a 512 px source can
            // never arrive 5 world units wide. Square size for square art keeps the
            // aspect check quiet too.
            _0x2572d1dd.drawMode = SpriteDrawMode.Sliced;
            _0x2572d1dd.size = new Vector2(this._0x29762ad2, this._0x29762ad2);
        }

        float _0x63102371 = LaneAngle(_0x5f0d8853.Lane);
        float _0xefa0cd93 = _0x63102371 * Mathf.Deg2Rad;
        Vector2 _0x4efb46c9 = this._0x7d60552e + (new Vector2(Mathf.Cos(_0xefa0cd93), Mathf.Sin(_0xefa0cd93)) * this._0xab814683);
        _0x0c02d024 _0x0214735d = _0x843a224e.GetComponent<_0x0c02d024>();
        if (_0x0214735d == null)
        {
            _0x0214735d = _0x843a224e.AddComponent<_0x0c02d024>();
        }

        float _0xbb1f0dbd = Mathf.Max(0.2f, _0x5f0d8853.ArriveAt - _0x5f0d8853.SpawnAt);
        _0x0214735d._0xbdb7c775(_0x2572d1dd, this._0x3437ce48, this._0x7d60552e, _0x4efb46c9, this._0xfe29fce4, _0xbb1f0dbd, _0x5f0d8853.Lane, _0x5f0d8853.IsHazard, _0x63102371, (_0x6b6e1ebd, _0xd68c8cc8, _0xa64c6df0) => this._0x6e8bbe4a(_0x6b6e1ebd, _0xd68c8cc8, _0xa64c6df0));
        this._0xfcb213e5.Add(_0x0214735d);
    }

    private float _0xab814683;
}