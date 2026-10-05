using DG.Tweening;
using UnityEngine;

/// The crystal's own state: three shards of energy, a charge meter that earns one
/// back, and a brief invulnerability so a volley cannot strip two shards at once.
///
/// It owns no layout. The HUD reads it and the arena animates it, which keeps the
/// rule about what happens separate from the rule about how it looks.
public sealed class _0x91a82fc2 : MonoBehaviour
{
    public int _0x981b7901
    {
        get
        {
            return this._0x952071db;
        }
    }

    // Built from camera metrics by the arena, so it is handed over rather than
    // wired in the scene file.
    private Transform _0x7345494e;
    /// Scale pulses are taken from the measured base scale, never from a literal:
    /// the crystal is sized from the camera, so a literal would be a different
    /// size on a different aspect (rule C.0).
    public void _0x2c822dcc()
    {
        if (this._0x7345494e == null)
        {
            return;
        }

        this._0x7345494e.DOKill();
        this._0x7345494e.localScale = this._0xb5ecb3d6;
        this._0x7345494e.DOScale(this._0xb5ecb3d6 * 1.06f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    public int _0x385996ea
    {
        get
        {
            return this._0x63e1e742;
        }
    }

    private int _0x605de686;
    private float _0x10387135;
    public void _0x55b53c7e()
    {
        if (this._0x7345494e == null)
        {
            return;
        }

        this._0x7345494e.DOShakePosition(0.25f, 0.12f);
    }

    private int _0x88bfda3f;
    public int _0x677ec9d0
    {
        get
        {
            return this._0x605de686;
        }
    }

    public void _0x699fde9a()
    {
        if (this._0x7345494e == null)
        {
            return;
        }

        this._0x7345494e.DOKill();
        this._0x7345494e.DOShakeScale(0.3f, 0.4f);
    }

    public void _0x53a2a90d(Transform _0xbc105a97)
    {
        this._0x7345494e = _0xbc105a97;
        if (_0xbc105a97 != null)
        {
            this._0xb5ecb3d6 = _0xbc105a97.localScale;
        }
    }

    public int _0x09c21f20
    {
        get
        {
            return this._0x88bfda3f;
        }
    }

    private Vector3 _0xb5ecb3d6 = Vector3.one;
    public void _0xa967f38f()
    {
        this._0x952071db = _0x743cc942.CoreShards;
        this._0x88bfda3f = 0;
        this._0x63e1e742 = 0;
        this._0x605de686 = 0;
        this._0x10387135 = 0f;
        if (this._0x7345494e != null)
        {
            this._0xb5ecb3d6 = this._0x7345494e.localScale;
        }
    }

    /// A charge orb reached the core. Returns true when the meter completed, which
    /// is the moment worth a golden flash.
    public bool _0x89d4f1c9()
    {
        this._0x88bfda3f++;
        if (this._0x88bfda3f < _0x743cc942.ChargeTarget)
        {
            return false;
        }

        this._0x88bfda3f = 0;
        if (this._0x952071db < _0x743cc942.CoreShards)
        {
            this._0x952071db++;
        }
        else
        {
            // Core already whole: the surplus is banked as progress instead.
            _0xd8d0855e._0xd165425b._0xd82d10c8 = _0xd8d0855e._0xd165425b._0xd82d10c8 + 1;
        }

        return true;
    }

    private int _0x952071db;
    private int _0x63e1e742;
    /// A hazard reached the core. Returns true when a shard was actually spent, so
    /// the caller only plays the damage sequence for a real loss.
    public bool _0x1ffe08e1()
    {
        if (Time.time < this._0x10387135 || this._0x952071db <= 0)
        {
            return false;
        }

        this._0x10387135 = Time.time + _0x743cc942.InvulnSeconds;
        this._0x952071db--;
        this._0x63e1e742 = 0;
        return true;
    }

    public bool _0x321c467d
    {
        get
        {
            return this._0x952071db > 0;
        }
    }

    public void _0x89ee9a47()
    {
        if (this._0x7345494e == null)
        {
            return;
        }

        this._0x7345494e.DOKill();
        this._0x7345494e.localScale = this._0xb5ecb3d6;
        this._0x7345494e.DOScale(this._0xb5ecb3d6 * 1.3f, 0.45f).SetEase(Ease.OutBack);
    }

    /// A hazard was bounced off a solid sector.
    public void _0xc1a9ece7()
    {
        this._0x63e1e742++;
        if (this._0x63e1e742 > this._0x605de686)
        {
            this._0x605de686 = this._0x63e1e742;
        }
    }
}