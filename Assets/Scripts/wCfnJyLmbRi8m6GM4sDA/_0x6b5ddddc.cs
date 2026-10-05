using DG.Tweening;
using UnityEngine;

/// The guard ring: three solid sectors and one open gate, snapping in 90 degree
/// steps. Everything the rest of the game asks it is "which lane is open" and
/// "turn one step" - the visual angle is its own business.
public sealed class _0x6b5ddddc : MonoBehaviour
{
    public void _0x71bac2a9()
    {
        this._0x582a5f10(1);
    }

    private float _0xe3830ebf;
    private void _0x62be2ac7(bool _0xb22b8bc9)
    {
        float _0x889463a1 = 90f * this._0x95e676c3;
        if (this._0x9b6489e8 == null)
        {
            return;
        }

        if (!_0xb22b8bc9)
        {
            this._0x9b6489e8.localRotation = Quaternion.Euler(0f, 0f, _0x889463a1);
            return;
        }

        this._0x9b6489e8.DOKill();
        this._0x9b6489e8.DORotate(new Vector3(0f, 0f, _0x889463a1), StepSeconds, RotateMode.Fast).SetEase(Ease.OutBack);
    }

    private const float StepSeconds = 0.18f;
    public bool _0xf687cd86(int _0x03d6dfe7)
    {
        return _0x03d6dfe7 == this._0x95e676c3;
    }

    // The ring art is built from camera metrics at runtime, so these arrive through
    // Initialize rather than through the scene file - the sanctioned path where
    // serialization cannot reach the object.
    private Transform _0x9b1a901b;
    /// One queued input is remembered while a step plays, so a quick double tap
    /// turns twice instead of being swallowed; anything beyond that is dropped so
    /// the ring cannot run away from the player.
    private void _0x582a5f10(int _0x3c05a970)
    {
        if (Time.time < this._0xe3830ebf)
        {
            this._0x762ec15c = _0x3c05a970;
            return;
        }

        this._0x95e676c3 = ((this._0x95e676c3 + _0x3c05a970) % _0x743cc942.Lanes + _0x743cc942.Lanes) % _0x743cc942.Lanes;
        this._0xe3830ebf = Time.time + StepSeconds + CooldownSeconds;
        this._0x62be2ac7(true);
        int _0x0e46e1cc = this._0x762ec15c;
        this._0x762ec15c = 0;
        if (_0x0e46e1cc != 0)
        {
            DOVirtual.DelayedCall(StepSeconds + CooldownSeconds, () => this._0x582a5f10(_0x0e46e1cc));
        }
    }

    /// The solid part of the ring drifts slowly so the arena is never a still
    /// image, but it carries no gameplay meaning - the gate child holds the angle.
    public void _0xea26752d(bool _0x6fecee72)
    {
        if (this._0x9b1a901b == null)
        {
            return;
        }

        this._0x9b1a901b.DOKill();
        if (_0x6fecee72)
        {
            this._0x9b1a901b.DORotate(new Vector3(0f, 0f, -360f), 24f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        }
    }

    private int _0x762ec15c;
    /// Turns the gate towards a lane by the shorter way round - used by the tap
    /// shortcut on the arena, which names a destination rather than a direction.
    public void _0xf2fda0b8(int _0xfff27efa)
    {
        int _0x1b19a216 = ((_0xfff27efa - this._0x95e676c3) % _0x743cc942.Lanes + _0x743cc942.Lanes) % _0x743cc942.Lanes;
        if (_0x1b19a216 == 0)
        {
            return;
        }

        this._0x582a5f10(_0x1b19a216 == 3 ? -1 : 1);
    }

    private Transform _0x9b6489e8;
    private int _0x95e676c3;
    private const float CooldownSeconds = 0.12f;
    public void _0xfc33faac()
    {
        this._0x582a5f10(-1);
    }

    public void _0xbd58ddf1(int _0xd7c4a8de, Transform _0xcdc5bc93, Transform _0xf49d1c23)
    {
        this._0x9b1a901b = _0xcdc5bc93;
        this._0x9b6489e8 = _0xf49d1c23;
        this._0x95e676c3 = ((_0xd7c4a8de % _0x743cc942.Lanes) + _0x743cc942.Lanes) % _0x743cc942.Lanes;
        this._0xe3830ebf = 0f;
        this._0x762ec15c = 0;
        this._0x62be2ac7(false);
    }

    /// True while a step is still playing, so the HUD can show the ring is busy.
    public bool _0x64661e6c
    {
        get
        {
            return Time.time < this._0xe3830ebf;
        }
    }

    public int _0x4895c68a
    {
        get
        {
            return this._0x95e676c3;
        }
    }
}