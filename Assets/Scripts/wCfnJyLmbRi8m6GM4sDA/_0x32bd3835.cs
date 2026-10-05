using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The UGUI builders this game uses. Every number is in the canvas reference
/// resolution (1242 x 2688), so one set of coordinates reads the same on any
/// device, and every helper takes y measured from the TOP of the panel, which is
/// how the design document lays the screens out.
///
/// Sibling order is draw order, so each builder adds its surface FIRST and its
/// caption after: a plate can never cover its own label (rules C.13 / E.1).
public static class _0x32bd3835
{
    /// Corner radius of a 9-sliced plate: the higher the multiplier the smaller the
    /// drawn border and the sharper the corner. The floor keeps the two borders from
    /// meeting across a small plate, which is what smears a 60 px chip into a blob.
    public static float SliceScale(Vector2 _0x6b955544)
    {
        float _0x4193c98a = Mathf.Max(1f, Mathf.Min(_0x6b955544.x, _0x6b955544.y));
        return Mathf.Max(1.4f, 170f / _0x4193c98a);
    }

    /// A small indicator square - shard pip or charge segment.
    public static Image Pip(Transform _0x7abf53c7, string _0x9360758e, Vector2 _0xf4829ee5, Vector2 _0x2ce74d92, Sprite _0xf6f453fc, Color _0x9fdf36b8)
    {
        if (_0xf6f453fc != null)
        {
            return Picture(_0x7abf53c7, _0x9360758e, _0xf4829ee5, _0x2ce74d92, _0xf6f453fc, _0x9fdf36b8);
        }

        return Plate(_0x7abf53c7, _0x9360758e, _0xf4829ee5, _0x2ce74d92, null, _0x9fdf36b8);
    }

    /// A rect whose anchors collapse to a point, so its size is exactly what is
    /// written here and never inherited from a stretching parent.
    public static RectTransform Node(Transform _0x54b3a416, string _0x53a5e6b5, Vector2 _0x565f1458, Vector2 _0x60573496)
    {
        GameObject _0x03386947 = new GameObject(_0x53a5e6b5, typeof(RectTransform));
        RectTransform _0x35c6b534 = _0x03386947.GetComponent<RectTransform>();
        _0x35c6b534.SetParent(_0x54b3a416, false);
        _0x35c6b534.anchorMin = new Vector2(0.5f, 0.5f);
        _0x35c6b534.anchorMax = new Vector2(0.5f, 0.5f);
        _0x35c6b534.pivot = new Vector2(0.5f, 0.5f);
        _0x35c6b534.anchoredPosition = _0x565f1458;
        _0x35c6b534.sizeDelta = _0x60573496;
        _0x35c6b534.localScale = Vector3.one;
        return _0x35c6b534;
    }

    public static TextMeshProUGUI Caption(Transform _0xcd1274b5, string _0xdcdf78ec, Vector2 _0x7537b1a1, Vector2 _0x7048e1ef, string _0xda9146bf, float _0x8ab5aa4b, Color _0xa8a695e4, TextAlignmentOptions _0xd950ac16, TMP_FontAsset _0x99b7952a)
    {
        RectTransform _0x3d8a0d16 = Node(_0xcd1274b5, _0xdcdf78ec, _0x7537b1a1, _0x7048e1ef);
        TextMeshProUGUI _0x627f0003 = _0x3d8a0d16.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x99b7952a != null)
        {
            _0x627f0003.font = _0x99b7952a;
        }

        _0x627f0003.text = _0xda9146bf;
        _0x627f0003.alignment = _0xd950ac16;
        _0x627f0003.raycastTarget = false;
        _0xd1591286.ApplyLayout(_0x627f0003, _0x8ab5aa4b);
        _0xd1591286.ApplyOutline(_0x627f0003, _0xa8a695e4);
        return _0x627f0003;
    }

    /// A rect stretched over its whole parent. A host made with new GameObject()
    /// starts at 100 x 100, and every child would then resolve its anchors against
    /// 100 x 100 instead of the panel - so this runs immediately after parenting.
    public static RectTransform Stretch(Transform _0x788eb69b, string _0x9e6493eb)
    {
        GameObject _0x3dd3ec95 = new GameObject(_0x9e6493eb, typeof(RectTransform));
        RectTransform _0xb855197a = _0x3dd3ec95.GetComponent<RectTransform>();
        _0xb855197a.SetParent(_0x788eb69b, false);
        _0xb855197a.anchorMin = Vector2.zero;
        _0xb855197a.anchorMax = Vector2.one;
        _0xb855197a.offsetMin = Vector2.zero;
        _0xb855197a.offsetMax = Vector2.zero;
        _0xb855197a.localScale = Vector3.one;
        return _0xb855197a;
    }

    /// A 9-sliced surface. Stretching is its purpose, so no aspect is preserved.
    public static Image Plate(Transform _0x2bc70904, string _0x9cceae39, Vector2 _0xf67731f8, Vector2 _0x3495c02c, Sprite _0x95e07a47, Color _0x4f623040)
    {
        RectTransform _0x7ae0ca0a = Node(_0x2bc70904, _0x9cceae39, _0xf67731f8, _0x3495c02c);
        Image _0x5de69513 = _0x7ae0ca0a.gameObject.AddComponent<Image>();
        _0x5de69513.sprite = _0x95e07a47;
        _0x5de69513.type = _0x95e07a47 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x5de69513.pixelsPerUnitMultiplier = SliceScale(_0x3495c02c);
        _0x5de69513.color = _0x4f623040;
        _0x5de69513.raycastTarget = false;
        return _0x5de69513;
    }

    /// Converts a design-document point (x from left, y from TOP) into the
    /// anchored position of a centre-anchored rect.
    public static Vector2 FromTop(float _0x1b27fb16, float _0x0934a7b1)
    {
        return new Vector2(_0x1b27fb16 - (RefWidth * 0.5f), (RefHeight * 0.5f) - _0x0934a7b1);
    }

    public const float RefWidth = 1242f;
    /// A pressable surface.
    ///
    /// `fill` is the colour of the PLATE and `tint` the colour of the TEXT - swapping
    /// them is what produces dark glyphs on a bright button. JewelPalette.TextTint
    /// inside the caption builder refuses a surface colour in the text argument, so
    /// the mistake cannot reach a screen.
    ///
    /// The fill image is both the press target and the visible face: a transparent
    /// hit layer as target graphic would give no visible press state at all, and
    /// rule C.7 wants the press to show on a screenshot.
    public static Button Cta(Transform _0x6de4b4f6, string _0x2d6b96cf, Vector2 _0x0ac46cd9, Vector2 _0x2841fc02, Sprite _0x31a41798, Color _0x9c2b2079, string _0x0190e564, float _0xadcca70f, Color _0x8d116182, TMP_FontAsset _0xae544c1c)
    {
        RectTransform _0xb5b7ead8 = Node(_0x6de4b4f6, _0x2d6b96cf, _0x0ac46cd9, _0x2841fc02);
        Image _0x5f4e468b = _0xb5b7ead8.gameObject.AddComponent<Image>();
        _0x5f4e468b.sprite = _0x31a41798;
        _0x5f4e468b.type = _0x31a41798 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x5f4e468b.pixelsPerUnitMultiplier = SliceScale(_0x2841fc02);
        _0x5f4e468b.color = _0x9c2b2079;
        _0x5f4e468b.raycastTarget = true;
        _0x5f4e468b.canvasRenderer.cullTransparentMesh = false;
        Button _0x5ced8fc8 = _0xb5b7ead8.gameObject.AddComponent<Button>();
        _0x5ced8fc8.targetGraphic = _0x5f4e468b;
        ColorBlock _0x30f99ca7 = _0x5ced8fc8.colors;
        _0x30f99ca7.normalColor = Color.white;
        _0x30f99ca7.highlightedColor = Color.white;
        _0x30f99ca7.pressedColor = new Color(0.78f, 0.78f, 0.78f, 1f);
        _0x30f99ca7.selectedColor = Color.white;
        _0x30f99ca7.fadeDuration = 0.08f;
        _0x5ced8fc8.colors = _0x30f99ca7;
        // Caption is added AFTER the surface, so it draws on top of it.
        Caption(_0xb5b7ead8, _0x2d6b96cf + _0xaedabfce._0x3a92ea9b(new byte[5] { 124, 81, 82, 85, 92 }, 48), Vector2.zero, new Vector2(_0x2841fc02.x - 48f, _0x2841fc02.y), _0x0190e564, _0xadcca70f, _0x8d116182, TextAlignmentOptions.Center, _0xae544c1c);
        return _0x5ced8fc8;
    }

    public const float RefHeight = 2688f;
    /// Content art. The sprite keeps its own proportions whatever box it is given,
    /// so a round charge orb can never arrive as an egg (rule F.2a).
    public static Image Picture(Transform _0x49efaccf, string _0xcaed56de, Vector2 _0xa37ccca9, Vector2 _0xdc437778, Sprite _0x7e83cdf5, Color _0x87db6cf9)
    {
        RectTransform _0x996f8f01 = Node(_0x49efaccf, _0xcaed56de, _0xa37ccca9, _0xdc437778);
        Image _0x9da8122d = _0x996f8f01.gameObject.AddComponent<Image>();
        _0x9da8122d.sprite = _0x7e83cdf5;
        _0x9da8122d.type = Image.Type.Simple;
        _0x9da8122d.preserveAspect = true;
        _0x9da8122d.color = _0x87db6cf9;
        _0x9da8122d.raycastTarget = false;
        return _0x9da8122d;
    }

    /// A full-surface catcher that still receives pointer events. The graphic
    /// raycaster skips a culled renderer, and an Image at alpha 0 with
    /// cullTransparentMesh on IS culled - so the alpha is small but non-zero and
    /// culling is turned off explicitly.
    public static Image TapSurface(Transform _0x1c4dd184, string _0x6063fde4)
    {
        RectTransform _0x4eaafe15 = Stretch(_0x1c4dd184, _0x6063fde4);
        Image _0xd52388b5 = _0x4eaafe15.gameObject.AddComponent<Image>();
        _0xd52388b5.color = new Color(0f, 0f, 0f, 0.004f);
        _0xd52388b5.raycastTarget = true;
        _0xd52388b5.canvasRenderer.cullTransparentMesh = false;
        return _0xd52388b5;
    }
}

internal static class _0xaedabfce
{
    internal static string _0x3a92ea9b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}