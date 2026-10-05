using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// Root of the game scene. It measures the arena from the camera, builds it,
/// starts the round and routes every outcome.
///
/// EVERY size here is derived from Camera.orthographicSize and the live aspect,
/// never written as a world literal (rule C.0): a literal that frames correctly on
/// 19.5:9 walks off the screen on a tablet. The one asset reference list in the
/// game scene lives on this component and is handed down to the parts.
public sealed class _0x0fd90b95 : MonoBehaviour, IPointerClickHandler
{
    private const int OrderFx = -4;
    private float _0xfe2621a0;
    private Transform _0x6cd58c6b;
    private void _0xc4fc6ddc()
    {
        if (this._0x5c433071 || this._0x55927722)
        {
            return;
        }

        this._0x55927722 = true;
        this._0x88b5b756._0x662e5b9f(false);
        this._0xd054615b._0x20565886(false);
        if (this._pops != null)
        {
            this._pops._0xaf838b70(this._0x11ebe956._0x981b7901, this._0x88b5b756._0x6d2d16c0, () => this._0x488d4462());
        }
    }

    [SerializeField]
    private _0xbee2bbf3 _pops;
    private void _0x64009bca(_0xb28b8bb1 _0xd9d16e56, float _0xa11fb3cc)
    {
        if (this._pops == null)
        {
            return;
        }

        this._pops._0x598f47bf(_0xd9d16e56, this._0x11ebe956._0x981b7901, this._0x11ebe956._0x677ec9d0, _0xa11fb3cc, this._0x64b07a95);
    }

    // Draw order inside the sprite corridor -19..-1. The background canvas is at
    // -30 and every pop canvas is at 10, so nothing here can bury a result card.
    private const int OrderArena = -18;
    private void Start()
    {
        if (this._camera == null)
        {
            this._camera = Camera.main;
        }

        this._0x64b07a95 = _0x13547bff.Current();
        this._0x1ea63d86();
        this._0xe87e6711();
        this._0xd7164346();
        this._0xf26cff9c();
    }

    /// Tapping the arena turns the gate towards the tapped lane. The template's own
    /// InputController cannot be used for this - its instance and every touch getter
    /// are private, so a call would not compile - and a pointer handler on the panel
    /// is exact on any aspect without an aspect-fitter correction anyway.
    public void OnPointerClick(PointerEventData _0x8cf0ae6e)
    {
        if (this._0x55927722 || this._0x5c433071 || this._camera == null || _0x8cf0ae6e == null)
        {
            return;
        }

        Vector3 _0x01e5332c = this._camera.ScreenToWorldPoint(_0x8cf0ae6e.position);
        Vector2 _0x1d55b521 = new Vector2(_0x01e5332c.x, _0x01e5332c.y) - this._0xdb481a48;
        if (_0x1d55b521.sqrMagnitude < 0.0001f)
        {
            return;
        }

        float _0x153b0801 = Mathf.Atan2(_0x1d55b521.y, _0x1d55b521.x) * Mathf.Rad2Deg;
        int _0x2a08d6b1 = Mathf.RoundToInt(Mathf.Repeat(_0x153b0801, 360f) / 90f) % _0x743cc942.Lanes;
        this._0x6374958b._0xf2fda0b8(_0x2a08d6b1);
    }

    [SerializeField]
    private Sprite _gateArc;
    private const int OrderGate = -11;
    private const int OrderRing = -12;
    [SerializeField]
    private Sprite _hazardSprite;
    [SerializeField]
    private TMP_FontAsset _font;
    private readonly List<SpriteRenderer> _0xe0313071 = new List<SpriteRenderer>();
    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _burstSprite;
    private void _0x07afbc0e()
    {
        this._0x88b5b756._0x662e5b9f(true);
        this._0xd054615b._0x20565886(true);
    }

    private void _0x00d2d9ce()
    {
        for (int _0x24390ef1 = 0; _0x24390ef1 < this._0xc5b194e8.Count; _0x24390ef1++)
        {
            SpriteRenderer _0x6e4e8b1d = this._0xc5b194e8[_0x24390ef1];
            if (_0x6e4e8b1d == null)
            {
                continue;
            }

            bool _0x01ef475e = _0x24390ef1 < this._0x11ebe956._0x981b7901;
            _0x6e4e8b1d.DOKill();
            _0x6e4e8b1d.DOFade(_0x01ef475e ? 1f : 0.12f, 0.3f);
        }
    }

    private Transform _0x8bf3aefa;
    private void _0xf26cff9c()
    {
        int _0x1afdcc37 = _0x13547bff.NextAttempt();
        _0x2c4ae669 _0x9ec1efb8 = _0x743cc942.Build(this._0x64b07a95, _0x1afdcc37);
        this._0x6374958b._0xbd58ddf1(_0x9ec1efb8.StartGateLane, this._0x8bf3aefa, this._0x6cd58c6b);
        this._0x6374958b._0xea26752d(true);
        this._0x11ebe956._0xa967f38f();
        this._0x11ebe956._0x2c822dcc();
        this._0xd054615b._0xb4f94cb9(_0x9ec1efb8, this._0x6374958b, this._0x3d2a78c9, this._0xdb481a48, this._0xfe2621a0, this._0x2060f5f2, this._0xd80db7ac, this._0xe0313071, this._pulsePrefab, this._hazardSprite, this._chargeSprite, (_0xbad75eea, _0xd68c8cc8, _0xa64c6df0) => this._0x7d9fe087(_0xbad75eea, _0xd68c8cc8, _0xa64c6df0));
        this._0x88b5b756._0x31306ecb((_0x4113c74a) => this._0x36d31699(_0x4113c74a));
        this._0x88b5b756._0x662e5b9f(false);
        // Intro: the arena settles before anything is thrown at the player.
        DOVirtual.DelayedCall(IntroSeconds, () => this._0x07afbc0e());
    }

    // ---- input ------------------------------------------------------------
    private void _0x4d902712()
    {
        if (this._0x55927722 || this._0x5c433071)
        {
            return;
        }

        this._0x6374958b._0x71bac2a9();
    }

    private _0xa828d979 _0x88b5b756;
    private const int OrderRingGlow = -14;
    private Vector2 _0xdb481a48;
    private readonly List<SpriteRenderer> _0xc5b194e8 = new List<SpriteRenderer>();
    private _0xc05d9497 _0x61a39744;
    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _buttonPlate;
    private bool _0x5c433071;
    private _0x2d67212f _0xd054615b;
    [SerializeField]
    private Sprite _arenaDisc;
    [SerializeField]
    private Sprite _ringGlow;
    private void Update()
    {
        if (this._0x88b5b756 == null || this._0x61a39744 == null)
        {
            return;
        }

        if (this._0x88b5b756._0x995a85fb)
        {
            this._0xd054615b._0x2612caab(this._0x88b5b756._0x22a17ac0);
        }

        this._0x61a39744._0x9409cad2(this._0x11ebe956._0x981b7901, this._0x11ebe956._0x09c21f20, this._0x88b5b756._0x6d2d16c0);
    }

    private const int OrderShard = -9;
    [SerializeField]
    private Sprite _chargeSprite;
    private const int OrderPulse = -7;
    private const int OrderCrystal = -10;
    private void _0xf2ad4335(Vector2 _0x5a6ca8b8, Color _0x3dd8c49d)
    {
        SpriteRenderer _0x9ab66625 = this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[5] { 126, 73, 78, 79, 72 }, 60), this._0x3d2a78c9, this._burstSprite, this._0x9017183e, OrderFx, _0x3dd8c49d);
        _0x9ab66625.transform.position = new Vector3(_0x5a6ca8b8.x, _0x5a6ca8b8.y, 0f);
        _0x9ab66625.size = new Vector2(this._0x9017183e * 0.2f, this._0x9017183e * 0.2f);
        _0x9ab66625.DOFade(0f, 0.26f);
        DOTween.To(() => _0x9ab66625.size, (_0x8f37ea7c) => _0x9ab66625.size = _0x8f37ea7c, new Vector2(this._0x9017183e, this._0x9017183e), 0.18f);
        DOVirtual.DelayedCall(0.3f, () => this._0x3918ffd1(_0x9ab66625));
    }

    private const float OutroSeconds = 0.8f;
    private Transform _0xc4ef97e9;
    [SerializeField]
    private Camera _camera;
    private void _0x36d31699(_0xb28b8bb1 _0x1ae4fd42)
    {
        if (this._0x5c433071)
        {
            return;
        }

        this._0x5c433071 = true;
        this._0xd054615b._0x1078ebc4();
        float _0x0bdeea84 = _0x1ae4fd42 == _0xb28b8bb1.Held ? _0x743cc942.RoundSeconds : this._0x88b5b756._0x22a17ac0;
        _0x13547bff.RecordRun(this._0x64b07a95, _0x0bdeea84, this._0x11ebe956._0x981b7901);
        if (_0x1ae4fd42 == _0xb28b8bb1.Held)
        {
            this._0x11ebe956._0x89ee9a47();
        }
        else
        {
            this._0x11ebe956._0x699fde9a();
            this._0xf2ad4335(this._0xdb481a48, _0xa341162f.Crimson);
        }

        DOVirtual.DelayedCall(OutroSeconds, () => this._0x64009bca(_0x1ae4fd42, _0x0bdeea84));
    }

    /// Every radius in the game, expressed as a fraction of the camera's half
    /// width, so the whole arena scales with the device instead of being cropped.
    private void _0x1ea63d86()
    {
        float _0xb1c268e9 = this._camera != null ? this._camera.orthographicSize : 5f;
        float _0x51aafb1e = this._camera != null ? this._camera.aspect : (9f / 19.5f);
        float _0x110c6a6b = _0xb1c268e9 * _0x51aafb1e;
        this._0xdb481a48 = new Vector2(0f, _0xb1c268e9 * 0.09f);
        this._0xfe2621a0 = _0x110c6a6b * 0.95f;
        this._0x2060f5f2 = _0x110c6a6b * 0.52f;
        this._0xd80db7ac = _0x110c6a6b * 0.17f;
        this._0x9017183e = _0x110c6a6b * 0.40f;
    }

    private _0x91a82fc2 _0x11ebe956;
    /// One square world sprite. Size comes through m_size with Sliced draw mode,
    /// which makes the size authoritative and leaves the transform scale at one -
    /// the two must never fight (rule C.0, and the layout gate checks it).
    private SpriteRenderer MakeSprite(string _0xb9a2a2ad, Transform _0x66cc6b6f, Sprite _0xdddf2935, float _0x29f62d1d, int _0x590c51e2, Color _0x26c6416d)
    {
        GameObject _0x4905911c = new GameObject(_0xb9a2a2ad);
        _0x4905911c.transform.SetParent(_0x66cc6b6f, false);
        _0x4905911c.transform.localScale = Vector3.one;
        SpriteRenderer _0x0fabcd51 = _0x4905911c.AddComponent<SpriteRenderer>();
        _0x0fabcd51.sprite = _0xdddf2935;
        _0x0fabcd51.sortingOrder = Mathf.Clamp(_0x590c51e2, -19, -1);
        _0x0fabcd51.color = _0x26c6416d;
        _0x0fabcd51.drawMode = SpriteDrawMode.Sliced;
        _0x0fabcd51.size = new Vector2(_0x29f62d1d, _0x29f62d1d);
        return _0x0fabcd51;
    }

    private float _0xd80db7ac;
    private float _0x9017183e;
    private void _0x26ab458d()
    {
        _0x3ede361b.Instance.LoadSceneByIndex(_0xd8d0855e._0xe62aa36f.SCENE_0);
    }

    private void _0x74770290()
    {
        if (this._0x55927722 || this._0x5c433071)
        {
            return;
        }

        this._0x6374958b._0xfc33faac();
    }

    [SerializeField]
    private Sprite _shardSprite;
    [SerializeField]
    private Sprite _crystalSprite;
    private void _0x7d9fe087(_0x0c02d024 _0xae1049b7, bool _0x47ed6381, bool _0xb85bb778)
    {
        if (this._0x5c433071)
        {
            return;
        }

        if (!_0x47ed6381)
        {
            // Bounced off a solid sector.
            if (_0xb85bb778)
            {
                this._0x11ebe956._0xc1a9ece7();
                this._0xf2ad4335(_0xae1049b7._0x8701c280, _0xa341162f.Gold);
            }

            return;
        }

        if (_0xb85bb778)
        {
            if (this._0x11ebe956._0x1ffe08e1())
            {
                this._0x11ebe956._0x55b53c7e();
                this._0x61a39744._0x1fbefb20();
                this._0xf2ad4335(this._0xdb481a48, _0xa341162f.Crimson);
                this._0x00d2d9ce();
                if (!this._0x11ebe956._0x321c467d)
                {
                    this._0x88b5b756._0x03b01af7(_0xb28b8bb1.Shattered);
                }
            }

            return;
        }

        if (this._0x11ebe956._0x89d4f1c9())
        {
            this._0xf2ad4335(this._0xdb481a48, _0xa341162f.Gold);
            this._0x00d2d9ce();
        }
    }

    [SerializeField]
    private Sprite _ringGuard;
    private _0x6b5ddddc _0x6374958b;
    private const float IntroSeconds = 1.2f;
    [SerializeField]
    private Sprite _laneTrack;
    private int _0x64b07a95;
    private Transform _0x3d2a78c9;
    private float _0x2060f5f2;
    private void _0xd7164346()
    {
        Transform _0xa56677ba = _0x2eb0f825.PanelBody(_0xd8d0855e._0x1a8d0e5d.DEFAULT);
        if (_0xa56677ba == null)
        {
            return;
        }

        _0x2eb0f825.ClearPanelBody(_0xd8d0855e._0x1a8d0e5d.DEFAULT, null);
        _0x2eb0f825.BlankUnusedPages(-1, -1);
        RectTransform _0xcbb386fd = _0x32bd3835.Stretch(_0xa56677ba, _0x0a06f072._0x7fb6f661(new byte[12] { 86, 113, 106, 77, 106, 112, 97, 118, 98, 101, 103, 97 }, 4));
        // Tap catcher goes in FIRST so every button built after it wins the raycast.
        Image _0x2d601c0d = _0x32bd3835.TapSurface(_0xcbb386fd, _0x0a06f072._0x7fb6f661(new byte[12] { 161, 146, 133, 142, 129, 180, 129, 144, 186, 143, 142, 133 }, 224));
        _0x2d601c0d.gameObject.AddComponent<_0xb5e3c385>()._0xcdef5066(this);
        this._0x61a39744 = this.gameObject.AddComponent<_0xc05d9497>();
        this._0x61a39744.Build(_0xcbb386fd, this._font, this._shardSprite, this._buttonPlate, this._0x64b07a95);
        // BACK and PAUSE are this game's own objects. The template's LEFT_BUTTON /
        // RIGHT_BUTTON are deliberately left untouched and are switched off by the
        // pipeline's own leftover stage, so the panel ends up with ONE button set.
        Button _0xa416aa4a = _0x32bd3835.Cta(_0xcbb386fd, _0x0a06f072._0x7fb6f661(new byte[10] { 178, 145, 147, 155, 178, 133, 132, 132, 159, 158 }, 240), _0x32bd3835.FromTop(96f, 170f), new Vector2(128f, 128f), this._buttonPlate, _0xa341162f.Violet, string.Empty, 30f, _0xa341162f.Cream, this._font);
        _0x32bd3835.Picture(_0xa416aa4a.transform, _0x0a06f072._0x7fb6f661(new byte[9] { 56, 27, 25, 17, 61, 22, 3, 10, 18 }, 122), Vector2.zero, new Vector2(64f, 64f), this._iconBack, _0xa341162f.Cream);
        _0xa416aa4a.onClick.AddListener(() => this._0x26ab458d());
        Button _0xd34e45d2 = _0x32bd3835.Cta(_0xcbb386fd, _0x0a06f072._0x7fb6f661(new byte[11] { 15, 62, 42, 44, 58, 29, 42, 43, 43, 48, 49 }, 95), _0x32bd3835.FromTop(1146f, 170f), new Vector2(128f, 128f), this._buttonPlate, _0xa341162f.Violet, string.Empty, 30f, _0xa341162f.Cream, this._font);
        _0x32bd3835.Picture(_0xd34e45d2.transform, _0x0a06f072._0x7fb6f661(new byte[10] { 83, 98, 118, 112, 102, 68, 111, 122, 115, 107 }, 3), Vector2.zero, new Vector2(56f, 56f), this._iconPause, _0xa341162f.Cream);
        _0xd34e45d2.onClick.AddListener(() => this._0xc4fc6ddc());
        Button _0xe99bcb21 = _0x32bd3835.Cta(_0xcbb386fd, _0x0a06f072._0x7fb6f661(new byte[14] { 191, 158, 153, 133, 167, 142, 141, 159, 169, 158, 159, 159, 132, 133 }, 235), _0x32bd3835.FromTop(335f, 2379f), new Vector2(540f, 170f), this._buttonPlate, _0xa341162f.Violet, _0x0a06f072._0x7fb6f661(new byte[9] { 230, 231, 224, 252, 146, 254, 247, 244, 230 }, 178), 46f, _0xa341162f.Cream, this._font);
        _0xe99bcb21.onClick.AddListener(() => this._0x4d902712());
        Button _0x2ed07dd8 = _0x32bd3835.Cta(_0xcbb386fd, _0x0a06f072._0x7fb6f661(new byte[15] { 233, 200, 207, 211, 239, 212, 218, 213, 201, 255, 200, 201, 201, 210, 211 }, 189), _0x32bd3835.FromTop(907f, 2379f), new Vector2(540f, 170f), this._buttonPlate, _0xa341162f.Violet, _0x0a06f072._0x7fb6f661(new byte[10] { 244, 245, 242, 238, 128, 242, 233, 231, 232, 244 }, 160), 46f, _0xa341162f.Cream, this._font);
        _0x2ed07dd8.onClick.AddListener(() => this._0x74770290());
        if (this._pops != null)
        {
            this._pops._0x89b64242(this._font, this._buttonPlate);
        }
    }

    [SerializeField]
    private GameObject _pulsePrefab;
    private const int OrderLane = -16;
    private void _0xe87e6711()
    {
        GameObject _0x561ddc92 = new GameObject(_0x0a06f072._0x7fb6f661(new byte[5] { 158, 173, 186, 177, 190 }, 223));
        _0x561ddc92.transform.SetParent(this.transform, false);
        _0x561ddc92.transform.position = new Vector3(this._0xdb481a48.x, this._0xdb481a48.y, 0f);
        this._0xc4ef97e9 = _0x561ddc92.transform;
        float _0xbfe9a9f0 = this._camera != null ? this._camera.orthographicSize : 5f;
        float _0x57db76aa = _0xbfe9a9f0 * (this._camera != null ? this._camera.aspect : (9f / 19.5f));
        // Decoration first, so the content built after it draws on top (rule C.13).
        this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[9] { 92, 111, 120, 115, 124, 89, 116, 110, 126 }, 29), this._0xc4ef97e9, this._arenaDisc, this._0xfe2621a0 * 2.05f, OrderArena, _0xa341162f.WithAlpha(_0xa341162f.Void, 0.92f));
        float _0x4af8b9c7 = this._0xfe2621a0 - this._0x2060f5f2;
        for (int _0xa2d33e9d = 0; _0xa2d33e9d < _0x743cc942.Lanes; _0xa2d33e9d++)
        {
            float _0x28a167ae = _0x2d67212f.LaneAngle(_0xa2d33e9d);
            float _0x20292f39 = _0x28a167ae * Mathf.Deg2Rad;
            GameObject _0x603e7b1b = new GameObject(_0x0a06f072._0x7fb6f661(new byte[9] { 244, 217, 214, 221, 236, 202, 217, 219, 211 }, 184));
            _0x603e7b1b.transform.SetParent(this._0xc4ef97e9, false);
            float _0xc0824662 = this._0x2060f5f2 + (_0x4af8b9c7 * 0.5f);
            _0x603e7b1b.transform.localPosition = new Vector3(Mathf.Cos(_0x20292f39) * _0xc0824662, Mathf.Sin(_0x20292f39) * _0xc0824662, 0f);
            _0x603e7b1b.transform.localRotation = Quaternion.Euler(0f, 0f, _0x28a167ae);
            SpriteRenderer _0x793952d7 = _0x603e7b1b.AddComponent<SpriteRenderer>();
            _0x793952d7.sprite = this._laneTrack;
            _0x793952d7.sortingOrder = Mathf.Clamp(OrderLane, -19, -1);
            _0x793952d7.color = _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.75f);
            // Sliced: this sprite is a rail and stretching along its length is the
            // whole point, which is why its meta carries a real 9-slice border.
            _0x793952d7.drawMode = SpriteDrawMode.Sliced;
            _0x793952d7.size = new Vector2(_0x4af8b9c7, _0x57db76aa * 0.10f);
            this._0xe0313071.Add(_0x793952d7);
        }

        this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[8] { 32, 27, 28, 21, 53, 30, 29, 5 }, 114), this._0xc4ef97e9, this._ringGlow, this._0x2060f5f2 * 2.6f, OrderRingGlow, _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.45f));
        GameObject _0x9bf41ed5 = new GameObject(_0x0a06f072._0x7fb6f661(new byte[8] { 165, 158, 153, 144, 165, 152, 152, 131 }, 247));
        _0x9bf41ed5.transform.SetParent(this._0xc4ef97e9, false);
        this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[9] { 10, 49, 54, 63, 31, 45, 57, 42, 60 }, 88), _0x9bf41ed5.transform, this._ringGuard, this._0x2060f5f2 * 2.1f, OrderRing, _0xa341162f.Violet);
        GameObject _0x8f7e4510 = new GameObject(_0x0a06f072._0x7fb6f661(new byte[8] { 158, 184, 173, 188, 139, 182, 182, 173 }, 217));
        _0x8f7e4510.transform.SetParent(this._0xc4ef97e9, false);
        this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[7] { 235, 205, 216, 201, 237, 222, 207 }, 172), _0x8f7e4510.transform, this._gateArc, this._0x2060f5f2 * 2.1f, OrderGate, _0xa341162f.Teal);
        SpriteRenderer _0x09f08236 = this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[7] { 11, 58, 49, 59, 60, 41, 36 }, 72), this._0xc4ef97e9, this._crystalSprite, this._0x2060f5f2 * 0.71f, OrderCrystal, _0xa341162f.Gold);
        Transform _0x39b254de = _0x09f08236.transform;
        // Three shards orbiting the crystal: the same count as the HUD column, so
        // the player can read remaining energy without looking up.
        for (int _0xc5e55738 = 0; _0xc5e55738 < _0x743cc942.CoreShards; _0xc5e55738++)
        {
            float _0xbe3f937b = 90f + (120f * _0xc5e55738);
            float _0x2e35e791 = _0xbe3f937b * Mathf.Deg2Rad;
            float _0x22a2c69d = this._0x2060f5f2 * 0.55f;
            SpriteRenderer _0xb3a82643 = this.MakeSprite(_0x0a06f072._0x7fb6f661(new byte[10] { 96, 93, 77, 70, 91, 124, 71, 78, 93, 75 }, 47), this._0xc4ef97e9, this._shardSprite, this._0x2060f5f2 * 0.26f, OrderShard, _0xa341162f.Gold);
            _0xb3a82643.transform.localPosition = new Vector3(Mathf.Cos(_0x2e35e791) * _0x22a2c69d, Mathf.Sin(_0x2e35e791) * _0x22a2c69d, 0f);
            this._0xc5b194e8.Add(_0xb3a82643);
        }

        GameObject _0x00d49e7a = new GameObject(_0x0a06f072._0x7fb6f661(new byte[6] { 44, 18, 34, 5, 25, 30 }, 106));
        _0x00d49e7a.transform.SetParent(this._0xc4ef97e9, false);
        this._0x3d2a78c9 = _0x00d49e7a.transform;
        this._0x6374958b = this.gameObject.AddComponent<_0x6b5ddddc>();
        this._0x11ebe956 = this.gameObject.AddComponent<_0x91a82fc2>();
        this._0x88b5b756 = this.gameObject.AddComponent<_0xa828d979>();
        this._0xd054615b = this.gameObject.AddComponent<_0x2d67212f>();
        this._0x11ebe956._0x53a2a90d(_0x39b254de);
        this._0x8bf3aefa = _0x9bf41ed5.transform;
        this._0x6cd58c6b = _0x8f7e4510.transform;
    }

    private void _0x3918ffd1(SpriteRenderer _0x0f6027a4)
    {
        if (_0x0f6027a4 != null && _0x0f6027a4.gameObject != null)
        {
            Destroy(_0x0f6027a4.gameObject);
        }
    }

    private void _0x488d4462()
    {
        if (this._0x5c433071 || !this._0x55927722)
        {
            return;
        }

        this._0x55927722 = false;
        this._0x88b5b756._0x662e5b9f(true);
        this._0xd054615b._0x20565886(true);
    }

    private bool _0x55927722;
}

internal static class _0x0a06f072
{
    internal static string _0x7fb6f661(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}