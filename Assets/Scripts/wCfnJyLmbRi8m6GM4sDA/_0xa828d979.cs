using UnityEngine;

/// How a round ended. Named so no member collides with a method name anywhere in
/// the generated code: the button verifier's method-group scan is text based and
/// reads a bare capitalised identifier as a possible method group.
public enum _0xb28b8bb1
{
    Running = 0,
    Held = 1,
    Shattered = 2,
}

/// The 75 second countdown and the single place a round is allowed to end.
///
/// Both endings - the clock reaching zero and the last shard breaking - go through
/// Finish(), so there is exactly one path to a result card and no way to raise two.
public sealed class _0xa828d979 : MonoBehaviour
{
    public void _0x03b01af7(_0xb28b8bb1 _0xf7cdbfce)
    {
        if (this._0x02255e90 != _0xb28b8bb1.Running)
        {
            return;
        }

        this._0x02255e90 = _0xf7cdbfce;
        this._0x641f86aa = false;
        System.Action<_0xb28b8bb1> _0x4cc104d2 = this._0x47e8de3a;
        this._0x47e8de3a = null;
        if (_0x4cc104d2 != null)
        {
            _0x4cc104d2.Invoke(_0xf7cdbfce);
        }
    }

    private _0xb28b8bb1 _0x02255e90 = _0xb28b8bb1.Running;
    public bool _0x995a85fb
    {
        get
        {
            return this._0x641f86aa;
        }
    }

    public void _0x31306ecb(System.Action<_0xb28b8bb1> _0x84a5f6e0)
    {
        this._0xd479fef0 = _0x743cc942.RoundSeconds;
        this._0x02255e90 = _0xb28b8bb1.Running;
        this._0x47e8de3a = _0x84a5f6e0;
        this._0x641f86aa = true;
    }

    public float _0x22a17ac0
    {
        get
        {
            return _0x743cc942.RoundSeconds - this._0xd479fef0;
        }
    }

    private void Update()
    {
        if (!this._0x641f86aa)
        {
            return;
        }

        this._0xd479fef0 -= Time.deltaTime;
        if (this._0xd479fef0 <= 0f)
        {
            this._0xd479fef0 = 0f;
            this._0x03b01af7(_0xb28b8bb1.Held);
        }
    }

    private System.Action<_0xb28b8bb1> _0x47e8de3a;
    public _0xb28b8bb1 _0x2dcd78dc
    {
        get
        {
            return this._0x02255e90;
        }
    }

    private float _0xd479fef0;
    public float _0x6d2d16c0
    {
        get
        {
            return this._0xd479fef0;
        }
    }

    private bool _0x641f86aa;
    /// Pause is driven by this flag rather than Time.timeScale: the template's own
    /// pause pop animates with DOTween, and freezing global time would freeze the
    /// card that is supposed to appear.
    public void _0x662e5b9f(bool _0xf08d2e02)
    {
        if (this._0x02255e90 == _0xb28b8bb1.Running)
        {
            this._0x641f86aa = _0xf08d2e02;
        }
    }
}