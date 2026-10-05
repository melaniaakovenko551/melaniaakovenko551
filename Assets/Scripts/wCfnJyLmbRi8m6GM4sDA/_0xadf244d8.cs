using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Root of the menu scene: builds the home screen, the mode sheet and the two how
/// to play pages, and dresses the splash.
///
/// The START control is the template's own scene-loading button. This game draws a
/// face for it as a CHILD rather than adding a second button: every Image in the
/// template's button prefab ships with raycastTarget off and the button root has no
/// graphic of its own, so without a child that accepts pointers the control is
/// physically unpressable. UGUI bubbles the press up to the ancestor Button, so the
/// template's own LoadSceneButton still performs the load and this game never calls
/// LoadSceneByIndex for it - which would load the scene twice.
public sealed class _0xadf244d8 : MonoBehaviour
{
    [SerializeField]
    private Sprite _crystalSprite;
    [SerializeField]
    private Sprite _buttonPlate;
    [SerializeField]
    private Sprite _gateArc;
    [SerializeField]
    private Sprite _ringGlow;
    [SerializeField]
    private Sprite _shardSprite;
    private TextMeshProUGUI _0xa00b93ac;
    private _0xbe9b3d4a _0x9ad60f41;
    private _0xb19f6aca _0x906c1a52;
    [SerializeField]
    private TMP_FontAsset _font;
    /// Branding for the loading screen: the crystal inside the turning guard ring,
    /// which is the mechanic as a mark. There is no game name here, on purpose and
    /// by rule - the brand is the shape.
    ///
    /// The mark is inserted as the FIRST child of the splash body so it draws
    /// underneath the loading bar that already lives there, and the bar keeps the
    /// size and colours its own prefab gives it.
    private void _0xda2a94a9()
    {
        Transform _0x8cb3fc92 = _0x2eb0f825.PanelBody(_0xd8d0855e._0x1a8d0e5d.SPLASH);
        if (_0x8cb3fc92 == null)
        {
            return;
        }

        RectTransform _0x971dc4a8 = _0x32bd3835.Stretch(_0x8cb3fc92, _0xf7a78bd5._0xdf2bdac3(new byte[10] { 56, 27, 7, 10, 24, 3, 38, 10, 25, 0 }, 107));
        _0x971dc4a8.SetAsFirstSibling();
        Image _0x5b754683 = _0x971dc4a8.gameObject.AddComponent<Image>();
        _0x5b754683.color = _0xa341162f.WithAlpha(_0xa341162f.Void, 0.72f);
        _0x5b754683.raycastTarget = false;
        RectTransform _0xa8a5e551 = _0x32bd3835.Node(_0x971dc4a8, _0xf7a78bd5._0xdf2bdac3(new byte[12] { 100, 71, 91, 86, 68, 95, 114, 90, 85, 91, 82, 90 }, 55), new Vector2(0f, 320f), new Vector2(640f, 640f));
        _0x32bd3835.Picture(_0xa8a5e551, _0xf7a78bd5._0xdf2bdac3(new byte[10] { 203, 232, 244, 249, 235, 240, 223, 244, 247, 239 }, 152), Vector2.zero, new Vector2(640f, 640f), this._ringGlow, _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.5f));
        RectTransform _0x25239981 = _0x32bd3835.Node(_0xa8a5e551, _0xf7a78bd5._0xdf2bdac3(new byte[10] { 45, 14, 18, 31, 13, 22, 44, 23, 16, 25 }, 126), Vector2.zero, new Vector2(520f, 520f));
        _0x32bd3835.Picture(_0x25239981, _0xf7a78bd5._0xdf2bdac3(new byte[13] { 219, 248, 228, 233, 251, 224, 218, 225, 230, 239, 201, 250, 252 }, 136), Vector2.zero, new Vector2(520f, 520f), this._ringGuard, _0xa341162f.Violet);
        _0x32bd3835.Picture(_0x25239981, _0xf7a78bd5._0xdf2bdac3(new byte[13] { 11, 40, 52, 57, 43, 48, 31, 57, 44, 61, 25, 42, 44 }, 88), Vector2.zero, new Vector2(520f, 520f), this._gateArc, _0xa341162f.Teal);
        _0x25239981.DOLocalRotate(new Vector3(0f, 0f, -360f), 6f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        RectTransform _0x922b7064 = _0x32bd3835.Node(_0xa8a5e551, _0xf7a78bd5._0xdf2bdac3(new byte[11] { 87, 116, 104, 101, 119, 108, 87, 112, 107, 106, 97 }, 4), Vector2.zero, new Vector2(230f, 230f));
        _0x32bd3835.Picture(_0x922b7064, _0xf7a78bd5._0xdf2bdac3(new byte[14] { 179, 144, 140, 129, 147, 136, 179, 148, 143, 142, 133, 161, 146, 148 }, 224), Vector2.zero, new Vector2(230f, 230f), this._crystalSprite, _0xa341162f.Gold);
        _0x922b7064.localScale = Vector3.one;
        _0x922b7064.DOScale(1.06f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        _0x32bd3835.Caption(_0x971dc4a8, _0xf7a78bd5._0xdf2bdac3(new byte[10] { 25, 58, 38, 43, 57, 34, 6, 35, 36, 47 }, 74), new Vector2(0f, -210f), new Vector2(820f, 80f), _0xf7a78bd5._0xdf2bdac3(new byte[7] { 72, 75, 69, 64, 77, 74, 67 }, 4), 36f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._font);
    }

    private void Start()
    {
        Transform _0x857f6664 = _0x2eb0f825.PanelBody(_0xd8d0855e._0x1a8d0e5d.DEFAULT);
        if (_0x857f6664 == null)
        {
            return;
        }

        // Everything the template put here goes, except the branch holding the
        // scene-loading button this game reuses as START.
        _0x2eb0f825.ClearPanelBody(_0xd8d0855e._0x1a8d0e5d.DEFAULT, this._startButtonHost);
        _0x2eb0f825.BlankUnusedPages(_0xd8d0855e._0x1a8d0e5d.TUTORIAL0, _0xd8d0855e._0x1a8d0e5d.TUTORIAL1);
        RectTransform _0xc3505b3d = _0x32bd3835.Stretch(_0x857f6664, _0xf7a78bd5._0xdf2bdac3(new byte[8] { 68, 108, 103, 124, 91, 102, 102, 125 }, 9));
        // The host must not eat the START press, so it carries no graphic at all.
        this.BuildHome(_0xc3505b3d);
        this._0x00f201f6();
        this._0x482a6afd = this.gameObject.AddComponent<_0x4e45ebf6>();
        this._0x482a6afd.Build(this._font, this._buttonPlate, this._ringGuard, this._gateArc, this._hazardSprite, this._chargeSprite, this._turnHint, this._crystalSprite);
        this._0x9ad60f41 = this.gameObject.AddComponent<_0xbe9b3d4a>();
        this._0x9ad60f41.Build(_0xc3505b3d, this._font, this._buttonPlate, this._closeIcon, this._shardSprite, this._0x906c1a52, (_0x48a29d58) => this._0x5ad6157d(_0x48a29d58));
        this._0xda2a94a9();
        this._0xa9888887(_0x13547bff.Current());
    }

    /// Draws the visible face of the template's START control inside the control
    /// itself, so the press target and the art are the same object.
    private void _0x00f201f6()
    {
        if (this._startButtonHost == null)
        {
            return;
        }

        RectTransform _0xef984f33 = _0x32bd3835.Stretch(this._startButtonHost, _0xf7a78bd5._0xdf2bdac3(new byte[9] { 73, 110, 123, 104, 110, 92, 123, 121, 127 }, 26));
        Image _0x53503e8f = _0xef984f33.gameObject.AddComponent<Image>();
        _0x53503e8f.sprite = this._buttonPlate;
        _0x53503e8f.type = this._buttonPlate != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x53503e8f.pixelsPerUnitMultiplier = _0x32bd3835.SliceScale(new Vector2(745f, 165f));
        _0x53503e8f.color = _0xa341162f.Violet;
        _0x53503e8f.raycastTarget = true;
        _0x53503e8f.canvasRenderer.cullTransparentMesh = false;
        _0x32bd3835.Caption(_0xef984f33, _0xf7a78bd5._0xdf2bdac3(new byte[10] { 55, 16, 5, 22, 16, 40, 5, 6, 1, 8 }, 100), Vector2.zero, new Vector2(649f, 140f), _0xf7a78bd5._0xdf2bdac3(new byte[5] { 196, 195, 214, 197, 195 }, 151), 62f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._font);
        _0xef984f33.DOKill();
        _0xef984f33.localScale = Vector3.one;
        _0xef984f33.DOScale(1.04f, 1.2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    private _0x4e45ebf6 _0x482a6afd;
    private void _0xe904fa17()
    {
        _0x4895092e.Instance._0xe77504a1(_0xd8d0855e._0x1a8d0e5d.TUTORIAL0);
    }

    [SerializeField]
    private Sprite _chargeSprite;
    private TextMeshProUGUI _0x987f1856;
    private void BuildHome(Transform _0xa4f86ffb)
    {
        int _0xe131cede = _0x13547bff.Current();
        this._0x1a068699 = _0x32bd3835.Caption(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[10] { 176, 135, 129, 141, 144, 134, 174, 139, 140, 135 }, 226), _0x32bd3835.FromTop(400f, 240f), new Vector2(620f, 112f), string.Empty, 38f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._font);
        // The menu template in this tarball carries no coin container at all, so
        // the progress bank is this game's own plate reading the same stored value.
        _0x32bd3835.Plate(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[14] { 159, 164, 173, 190, 168, 142, 173, 162, 167, 156, 160, 173, 184, 169 }, 204), _0x32bd3835.FromTop(1050f, 240f), new Vector2(300f, 112f), this._buttonPlate, _0xa341162f.WithAlpha(_0xa341162f.VoidLift, 0.9f));
        _0x32bd3835.Picture(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[13] { 18, 41, 32, 51, 37, 3, 32, 47, 42, 8, 34, 46, 47 }, 65), _0x32bd3835.FromTop(950f, 240f), new Vector2(56f, 56f), this._shardSprite, _0xa341162f.Gold);
        this._0x987f1856 = _0x32bd3835.Caption(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[14] { 34, 25, 16, 3, 21, 51, 16, 31, 26, 39, 16, 29, 4, 20 }, 113), _0x32bd3835.FromTop(1086f, 240f), new Vector2(180f, 80f), string.Empty, 40f, _0xa341162f.Gold, TextAlignmentOptions.Center, this._font);
        RectTransform _0xc960b185 = _0x32bd3835.Node(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[9] { 177, 156, 139, 150, 187, 149, 150, 154, 146 }, 249), _0x32bd3835.FromTop(621f, 1020f), new Vector2(900f, 900f));
        this._0x906c1a52 = this.gameObject.AddComponent<_0xb19f6aca>();
        this._0x906c1a52.Build(_0xc960b185, this._ringGuard, this._gateArc, this._crystalSprite, this._hazardSprite, this._chargeSprite, this._ringGlow);
        this._0x906c1a52._0x0dec4724(_0x13547bff.PulseSpeedMul(_0xe131cede));
        _0x32bd3835.Caption(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[9] { 190, 147, 155, 148, 146, 133, 152, 135, 148 }, 241), _0x32bd3835.FromTop(621f, 1750f), new Vector2(1060f, 100f), _0xf7a78bd5._0xdf2bdac3(new byte[28] { 230, 225, 226, 234, 142, 250, 230, 235, 142, 237, 225, 252, 235, 142, 232, 225, 252, 142, 153, 155, 142, 253, 235, 237, 225, 224, 234, 253 }, 174), 46f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._font);
        _0x32bd3835.Caption(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[12] { 52, 25, 17, 30, 24, 15, 18, 13, 30, 40, 14, 25 }, 123), _0x32bd3835.FromTop(621f, 1832f), new Vector2(1000f, 70f), _0xf7a78bd5._0xdf2bdac3(new byte[23] { 96, 110, 109, 97, 105, 2, 112, 103, 102, 2, 15, 2, 110, 103, 118, 2, 118, 103, 99, 110, 2, 107, 108 }, 34), 34f, _0xa341162f.Teal, TextAlignmentOptions.Center, this._font);
        Button _0xc05be763 = _0x32bd3835.Cta(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[9] { 103, 69, 78, 79, 89, 105, 66, 67, 90 }, 42), _0x32bd3835.FromTop(621f, 2150f), new Vector2(420f, 110f), this._buttonPlate, _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.9f), _0xf7a78bd5._0xdf2bdac3(new byte[5] { 76, 78, 69, 68, 82 }, 1), 40f, _0xa341162f.Cream, this._font);
        _0xc05be763.onClick.AddListener(() => this._0x143cd81d());
        Button _0xcf53074e = _0x32bd3835.Cta(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[9] { 19, 52, 44, 15, 52, 24, 51, 50, 43 }, 91), _0x32bd3835.FromTop(621f, 2320f), new Vector2(480f, 100f), this._buttonPlate, _0xa341162f.WithAlpha(_0xa341162f.VoidLift, 0.95f), _0xf7a78bd5._0xdf2bdac3(new byte[11] { 148, 147, 139, 252, 136, 147, 252, 140, 144, 157, 133 }, 220), 38f, _0xa341162f.Cream, this._font);
        _0xcf53074e.onClick.AddListener(() => this._0xe904fa17());
        this._0xa00b93ac = _0x32bd3835.Caption(_0xa4f86ffb, _0xf7a78bd5._0xdf2bdac3(new byte[11] { 78, 108, 103, 102, 80, 118, 110, 110, 98, 113, 122 }, 3), _0x32bd3835.FromTop(621f, 2500f), new Vector2(1000f, 90f), string.Empty, 36f, _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.8f), TextAlignmentOptions.Center, this._font);
    }

    [SerializeField]
    private RectTransform _startButtonHost;
    [SerializeField]
    private Sprite _ringGuard;
    [SerializeField]
    private Sprite _closeIcon;
    private void _0x5ad6157d(int _0xd2a4b0f5)
    {
        this._0xa9888887(_0xd2a4b0f5);
    }

    private TextMeshProUGUI _0x1a068699;
    private void _0x143cd81d()
    {
        if (this._0x9ad60f41 != null)
        {
            this._0x9ad60f41.Show();
        }
    }

    [SerializeField]
    private Sprite _hazardSprite;
    [SerializeField]
    private Sprite _turnHint;
    private void _0xa9888887(int _0x6c86cd3c)
    {
        float _0x296fc3d2 = _0x13547bff.BestTime(_0x6c86cd3c);
        if (this._0x1a068699 != null)
        {
            this._0x1a068699.text = _0x296fc3d2 > 0f ? _0xf7a78bd5._0xdf2bdac3(new byte[6] { 232, 239, 249, 254, 138, 138 }, 170) + _0x13547bff.Title(_0x6c86cd3c) + _0xf7a78bd5._0xdf2bdac3(new byte[2] { 6, 6 }, 38) + _0x13547bff.Clock(_0x296fc3d2) : _0xf7a78bd5._0xdf2bdac3(new byte[6] { 15, 8, 30, 25, 109, 109 }, 77) + _0x13547bff.Title(_0x6c86cd3c) + _0xf7a78bd5._0xdf2bdac3(new byte[12] { 43, 43, 69, 68, 43, 89, 94, 69, 43, 82, 78, 95 }, 11);
        }

        if (this._0xa00b93ac != null)
        {
            this._0xa00b93ac.text = _0x13547bff.Title(_0x6c86cd3c) + _0xf7a78bd5._0xdf2bdac3(new byte[15] { 243, 243, 243, 131, 134, 159, 128, 150, 243, 128, 131, 150, 150, 151, 243 }, 211) + _0x13547bff.SpeedLabel(_0x6c86cd3c);
        }

        if (this._0x987f1856 != null)
        {
            this._0x987f1856.text = _0xd8d0855e._0xd165425b._0xd82d10c8.ToString();
        }
    }
}

internal static class _0xf7a78bd5
{
    internal static string _0xdf2bdac3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}