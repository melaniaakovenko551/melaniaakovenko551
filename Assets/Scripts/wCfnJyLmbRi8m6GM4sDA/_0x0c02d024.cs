using DG.Tweening;
using UnityEngine;

/// One pulse travelling down its lane towards the ring, and what happens when it
/// gets there.
///
/// The hazard sprite is declared in the manifest as "side view, nose UP", so the
/// rotation that aims it along its lane is written against that declared
/// orientation rather than guessed: lane angle minus 90 degrees. The charge orb is
/// declared radially symmetric and is never rotated or flipped (rule C.8).
public sealed class _0x0c02d024 : MonoBehaviour
{
    /// At the ring: an open gate lets the pulse through to the core, a solid sector
    /// bounces it back out. The ring is read at the moment of ARRIVAL, which is what
    /// makes turning late still count.
    private void _0xa809f0ed()
    {
        this._0x679865be = true;
        bool _0xfb85e153 = this._0x31c76df7 != null && this._0x31c76df7._0xf687cd86(this._0x64f592e2);
        if (_0xfb85e153)
        {
            // Carry on into the core, then report.
            this.transform.DOMove(new Vector3(this._0xff5ef39d.x, this._0xff5ef39d.y, 0f), 0.14f).SetEase(Ease.InQuad).OnComplete(() => this._0xdf2ed043(true));
            return;
        }

        // Bounced: turn around and fly back out, fading as it goes.
        Vector2 _0xb5c1ecdd = (this._0xb2ffebeb - this._0xff5ef39d).normalized;
        Vector3 _0x6415b63c = new Vector3(this._0xff5ef39d.x, this._0xff5ef39d.y, 0f) + (new Vector3(_0xb5c1ecdd.x, _0xb5c1ecdd.y, 0f) * (this._0x3479ba37 * 2.2f));
        this.transform.DOMove(_0x6415b63c, 0.35f).SetEase(Ease.OutQuad);
        if (this._0x7681ed70 != null)
        {
            this._0x7681ed70.DOFade(0f, 0.35f);
        }

        DOVirtual.DelayedCall(0.35f, () => this._0xdf2ed043(false));
    }

    private float _0xd06ec8a0;
    public int _0x45988f57
    {
        get
        {
            return this._0x64f592e2;
        }
    }

    public Vector2 _0x8701c280
    {
        get
        {
            Vector2 _0x30414dc2 = (this._0xb2ffebeb - this._0xff5ef39d).normalized;
            return this._0xff5ef39d + (_0x30414dc2 * this._0x3479ba37);
        }
    }

    private bool _0xdadb0f5d;
    private void Update()
    {
        if (this._0x679865be)
        {
            return;
        }

        this._0x53234acd += Time.deltaTime;
        float _0x4aa3b4f9 = Mathf.Clamp01(this._0x53234acd / this._0xd06ec8a0);
        Vector2 _0xae594e2f = this._0x8701c280;
        Vector2 _0x65352264 = Vector2.Lerp(this._0xb2ffebeb, _0xae594e2f, _0x4aa3b4f9);
        this.transform.position = new Vector3(_0x65352264.x, _0x65352264.y, 0f);
        if (_0x4aa3b4f9 >= 1f)
        {
            this._0xa809f0ed();
        }
    }

    private void _0xdf2ed043(bool _0xa132d6cd)
    {
        System.Action<_0x0c02d024, bool, bool> _0xaa36fd18 = this._0x18433313;
        this._0x18433313 = null;
        if (_0xaa36fd18 != null)
        {
            _0xaa36fd18.Invoke(this, _0xa132d6cd, this._0xdadb0f5d);
        }
    }

    private Vector2 _0xb2ffebeb;
    private float _0x3479ba37;
    private Vector2 _0xff5ef39d;
    private SpriteRenderer _0x7681ed70;
    private _0x6b5ddddc _0x31c76df7;
    private System.Action<_0x0c02d024, bool, bool> _0x18433313;
    private void _0x161792d5()
    {
        if (this != null && this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }

    private bool _0x679865be;
    /// Serialized wiring is impossible for an object made by Instantiate, so the
    /// dependencies arrive through one explicit call instead (rule C: an explicit
    /// Initialize where serialization cannot reach).
    public void _0xbdb7c775(SpriteRenderer _0x42338f76, _0x6b5ddddc _0x77b97349, Vector2 _0x8d22ba35, Vector2 _0xff245a33, float _0xd485786d, float _0x2737ee51, int _0x4c88df44, bool _0x98d26ea7, float _0xe14c59b9, System.Action<_0x0c02d024, bool, bool> _0x2d9e052c)
    {
        this._0x7681ed70 = _0x42338f76;
        this._0x31c76df7 = _0x77b97349;
        this._0xff5ef39d = _0x8d22ba35;
        this._0xb2ffebeb = _0xff245a33;
        this._0x3479ba37 = _0xd485786d;
        this._0xd06ec8a0 = Mathf.Max(0.2f, _0x2737ee51);
        this._0x64f592e2 = _0x4c88df44;
        this._0xdadb0f5d = _0x98d26ea7;
        this._0x18433313 = _0x2d9e052c;
        this._0x53234acd = 0f;
        this._0x679865be = false;
        this.transform.position = new Vector3(_0xff245a33.x, _0xff245a33.y, 0f);
        if (_0x98d26ea7)
        {
            // Nose points UP in the source art, so align it with the inbound travel
            // direction by subtracting a quarter turn.
            this.transform.localRotation = Quaternion.Euler(0f, 0f, _0xe14c59b9 - 90f);
        }
    }

    /// Called when the round ends while this pulse is still in flight.
    public void _0x3be492c2()
    {
        this._0x679865be = true;
        this._0x18433313 = null;
        this.transform.DOKill();
        if (this._0x7681ed70 != null)
        {
            this._0x7681ed70.DOFade(0f, 0.3f).OnComplete(() => this._0x161792d5());
            return;
        }

        this._0x161792d5();
    }

    public bool _0xb1db628a
    {
        get
        {
            return this._0xdadb0f5d;
        }
    }

    private float _0x53234acd;
    private int _0x64f592e2;
}