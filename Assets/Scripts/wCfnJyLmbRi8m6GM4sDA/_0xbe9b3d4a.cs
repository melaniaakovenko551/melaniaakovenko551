using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The pulse-speed sheet: three rows, one stored choice, and three simultaneous
/// signs that the choice landed.
///
/// Rule C.7 asks for a change a reviewer can SEE on a still frame, and a swapped
/// caption alone is not that. Picking a row repaints it, punches it, and changes
/// the speed of the live preview behind the sheet - so motion, colour and text all
/// agree.
///
/// Row geometry keeps rule C.25: the record gutter and the text column do not
/// share a horizontal band. Gutter centre 86 with width 150 ends at 161; the text
/// column starts at 207 and is centred at 517, so the nearest edges are 46 apart.
public sealed class _0xbe9b3d4a : MonoBehaviour
{
    private void BuildRow(Transform _0x3c06eb39, int _0xd8c03eb0, Sprite _0x28b3a4f1)
    {
        float _0x9741aab7 = 240f - (_0xd8c03eb0 * 280f);
        RectTransform _0xcf094b66 = _0x32bd3835.Node(_0x3c06eb39, _0x8b01c1ae._0xc59d06a1(new byte[7] { 230, 196, 207, 206, 249, 196, 220 }, 171), new Vector2(0f, _0x9741aab7), new Vector2(940f, 230f));
        Image _0x41ecf3e2 = _0xcf094b66.gameObject.AddComponent<Image>();
        _0x41ecf3e2.sprite = this._0xcb705f66;
        _0x41ecf3e2.type = this._0xcb705f66 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x41ecf3e2.pixelsPerUnitMultiplier = _0x32bd3835.SliceScale(new Vector2(940f, 230f));
        _0x41ecf3e2.color = _0xa341162f.VoidLift;
        _0x41ecf3e2.raycastTarget = true;
        _0x41ecf3e2.canvasRenderer.cullTransparentMesh = false;
        this._0x55bd4ce3.Add(_0x41ecf3e2);
        Image _0x7a0e2889 = _0x32bd3835.Plate(_0xcf094b66, _0x8b01c1ae._0xc59d06a1(new byte[8] { 155, 166, 190, 143, 187, 168, 164, 172 }, 201), Vector2.zero, new Vector2(940f, 230f), this._0xcb705f66, _0xa341162f.WithAlpha(_0xa341162f.Gold, 0f));
        this._0x4701f2fe.Add(_0x7a0e2889);
        // Gutter: up to three shards standing for the stored result of this mode.
        int _0x796f0b8e = _0x13547bff.BestSaved(_0xd8c03eb0);
        for (int _0x6dde7b50 = 0; _0x6dde7b50 < _0x743cc942.CoreShards; _0x6dde7b50++)
        {
            float _0xcf930cbf = GutterCentre - 46f + (_0x6dde7b50 * 46f);
            _0x32bd3835.Picture(_0xcf094b66, _0x8b01c1ae._0xc59d06a1(new byte[8] { 169, 148, 140, 168, 147, 154, 137, 159 }, 251), new Vector2(_0xcf930cbf - 470f, 54f), new Vector2(40f, 40f), _0x28b3a4f1, _0x6dde7b50 < _0x796f0b8e ? _0xa341162f.Gold : _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.18f));
        }

        float _0x3c4a48fd = TextLeft + (TextWidth * 0.5f);
        _0x32bd3835.Caption(_0xcf094b66, _0x8b01c1ae._0xc59d06a1(new byte[8] { 115, 78, 86, 117, 72, 85, 77, 68 }, 33), new Vector2(_0x3c4a48fd - 470f, 46f), new Vector2(TextWidth, 70f), _0x13547bff.Title(_0xd8c03eb0) + _0x8b01c1ae._0xc59d06a1(new byte[3] { 166, 166, 166 }, 134) + _0x13547bff.SpeedLabel(_0xd8c03eb0), 48f, _0xa341162f.Cream, TextAlignmentOptions.Left, this._0x17c55a27);
        float _0x00c5d0f2 = _0x13547bff.BestTime(_0xd8c03eb0);
        string _0x2a0bf946 = _0x00c5d0f2 > 0f ? _0x8b01c1ae._0xc59d06a1(new byte[5] { 170, 173, 187, 188, 200 }, 232) + _0x13547bff.Clock(_0x00c5d0f2) + _0x8b01c1ae._0xc59d06a1(new byte[9] { 98, 98, 98, 17, 3, 20, 7, 6, 98 }, 66) + _0x796f0b8e + _0x8b01c1ae._0xc59d06a1(new byte[1] { 13 }, 34) + _0x743cc942.CoreShards : _0x8b01c1ae._0xc59d06a1(new byte[10] { 153, 152, 247, 133, 130, 153, 247, 142, 146, 131 }, 215);
        TMP_Text _0xd9ae8f25 = _0x32bd3835.Caption(_0xcf094b66, _0x8b01c1ae._0xc59d06a1(new byte[7] { 95, 98, 122, 79, 104, 126, 121 }, 13), new Vector2(_0x3c4a48fd - 470f, -40f), new Vector2(TextWidth, 60f), _0x2a0bf946, 36f, _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.85f), TextAlignmentOptions.Left, this._0x17c55a27);
        this._0xa243589a.Add(_0xd9ae8f25);
        Button _0x715d1827 = _0xcf094b66.gameObject.AddComponent<Button>();
        _0x715d1827.targetGraphic = _0x41ecf3e2;
        ColorBlock _0x8a709ab6 = _0x715d1827.colors;
        _0x8a709ab6.normalColor = Color.white;
        _0x8a709ab6.highlightedColor = Color.white;
        _0x8a709ab6.pressedColor = new Color(0.8f, 0.8f, 0.8f, 1f);
        _0x715d1827.colors = _0x8a709ab6;
        int _0x90b05aa4 = _0xd8c03eb0;
        _0x715d1827.onClick.AddListener(() => this._0x17658cfb(_0x90b05aa4));
    }

    private const float TextLeft = GutterCentre + (GutterWidth * 0.5f) + 46f;
    private void _0x7ee1eb96(int _0x0b64b696)
    {
        for (int _0x4532bdc8 = 0; _0x4532bdc8 < this._0x55bd4ce3.Count; _0x4532bdc8++)
        {
            bool _0xf09c851e = _0x4532bdc8 == _0x0b64b696;
            if (this._0x55bd4ce3[_0x4532bdc8] != null)
            {
                this._0x55bd4ce3[_0x4532bdc8].color = _0xf09c851e ? _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.9f) : _0xa341162f.WithAlpha(_0xa341162f.VoidLift, 0.35f);
            }

            if (this._0x4701f2fe[_0x4532bdc8] != null)
            {
                this._0x4701f2fe[_0x4532bdc8].color = _0xf09c851e ? _0xa341162f.Gold : _0xa341162f.WithAlpha(_0xa341162f.Gold, 0f);
            }

            if (this._0xa243589a[_0x4532bdc8] != null)
            {
                this._0xa243589a[_0x4532bdc8].alpha = _0xf09c851e ? 1f : 0.55f;
            }
        }
    }

    private Sprite _0xcb705f66;
    private const float GutterCentre = 86f;
    private readonly List<Image> _0x55bd4ce3 = new List<Image>();
    private const float TextWidth = 620f;
    private readonly List<Image> _0x4701f2fe = new List<Image>();
    public void Show()
    {
        if (this._0x77c8fc94 != null)
        {
            this._0x77c8fc94.SetActive(true);
        }
    }

    private readonly List<TMP_Text> _0xa243589a = new List<TMP_Text>();
    private _0xb19f6aca _0x38daf38c;
    private const float GutterWidth = 150f;
    private System.Action<int> _0x5a079fd1;
    public void _0xa2848776()
    {
        if (this._0x77c8fc94 != null)
        {
            this._0x77c8fc94.SetActive(false);
        }
    }

    public void Build(Transform _0xd63cd6b9, TMP_FontAsset _0x25216939, Sprite _0x96940af7, Sprite _0x39ad02dd, Sprite _0xdc8565f3, _0xb19f6aca _0x60e75ebb, System.Action<int> _0x49c7da4d)
    {
        this._0x17c55a27 = _0x25216939;
        this._0xcb705f66 = _0x96940af7;
        this._0x38daf38c = _0x60e75ebb;
        this._0x5a079fd1 = _0x49c7da4d;
        RectTransform _0x153d5729 = _0x32bd3835.Stretch(_0xd63cd6b9, _0x8b01c1ae._0xc59d06a1(new byte[11] { 126, 92, 87, 86, 124, 69, 86, 65, 95, 82, 74 }, 51));
        this._0x77c8fc94 = _0x153d5729.gameObject;
        // The shade is itself a close control, so a tap that misses the corner glyph
        // still dismisses the sheet instead of parking every later frame on it.
        Image _0x0ec4a7ee = _0x153d5729.gameObject.AddComponent<Image>();
        _0x0ec4a7ee.color = _0xa341162f.WithAlpha(_0xa341162f.VoidDeep, 0.78f);
        _0x0ec4a7ee.raycastTarget = true;
        _0x0ec4a7ee.canvasRenderer.cullTransparentMesh = false;
        Button _0x108971c0 = _0x153d5729.gameObject.AddComponent<Button>();
        _0x108971c0.transition = Selectable.Transition.None;
        _0x108971c0.targetGraphic = _0x0ec4a7ee;
        _0x108971c0.onClick.AddListener(() => this._0xa2848776());
        RectTransform _0x8930019d = _0x32bd3835.Node(_0x153d5729, _0x8b01c1ae._0xc59d06a1(new byte[8] { 198, 228, 239, 238, 200, 234, 249, 239 }, 139), _0x32bd3835.FromTop(621f, 1200f), new Vector2(1060f, 1180f));
        Image _0x24daca79 = _0x8930019d.gameObject.AddComponent<Image>();
        _0x24daca79.sprite = _0x96940af7;
        _0x24daca79.type = _0x96940af7 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x24daca79.pixelsPerUnitMultiplier = _0x32bd3835.SliceScale(new Vector2(1060f, 1180f));
        _0x24daca79.color = _0xa341162f.WithAlpha(_0xa341162f.Void, 0.97f);
        // Presses INSIDE the card must not reach the shade behind it.
        _0x24daca79.raycastTarget = true;
        _0x32bd3835.Caption(_0x8930019d, _0x8b01c1ae._0xc59d06a1(new byte[9] { 185, 155, 144, 145, 160, 157, 128, 152, 145 }, 244), new Vector2(0f, 440f), new Vector2(900f, 110f), _0x8b01c1ae._0xc59d06a1(new byte[11] { 4, 1, 24, 7, 17, 116, 7, 4, 17, 17, 16 }, 84), 56f, _0xa341162f.Gold, TextAlignmentOptions.Center, _0x25216939);
        Button _0x8e01b1a6 = _0x32bd3835.Cta(_0x8930019d, _0x8b01c1ae._0xc59d06a1(new byte[9] { 57, 27, 16, 17, 55, 24, 27, 7, 17 }, 116), new Vector2(460f, 440f), new Vector2(96f, 96f), _0x96940af7, _0xa341162f.WithAlpha(_0xa341162f.VoidLift, 0.9f), string.Empty, 30f, _0xa341162f.Cream, _0x25216939);
        _0x32bd3835.Picture(_0x8e01b1a6.transform, _0x8b01c1ae._0xc59d06a1(new byte[14] { 78, 108, 103, 102, 64, 111, 108, 112, 102, 68, 111, 122, 115, 107 }, 3), Vector2.zero, new Vector2(46f, 46f), _0x39ad02dd, _0xa341162f.Cream);
        _0x8e01b1a6.onClick.AddListener(() => this._0xa2848776());
        for (int _0x5808c419 = 0; _0x5808c419 < _0x13547bff.Count; _0x5808c419++)
        {
            this.BuildRow(_0x8930019d, _0x5808c419, _0xdc8565f3);
        }

        this._0x7ee1eb96(_0x13547bff.Current());
        this._0x77c8fc94.SetActive(false);
    }

    private void _0x17658cfb(int _0x70874aa4)
    {
        _0x13547bff.SetCurrent(_0x70874aa4);
        this._0x7ee1eb96(_0x70874aa4);
        if (_0x70874aa4 < this._0x55bd4ce3.Count && this._0x55bd4ce3[_0x70874aa4] != null)
        {
            Transform _0x13cdce7d = this._0x55bd4ce3[_0x70874aa4].transform;
            _0x13cdce7d.DOKill();
            _0x13cdce7d.localScale = Vector3.one;
            _0x13cdce7d.DOPunchScale(Vector3.one * 0.06f, 0.25f);
        }

        if (this._0x38daf38c != null)
        {
            this._0x38daf38c._0x0dec4724(_0x13547bff.PulseSpeedMul(_0x70874aa4));
        }

        if (this._0x5a079fd1 != null)
        {
            this._0x5a079fd1.Invoke(_0x70874aa4);
        }
    }

    private TMP_FontAsset _0x17c55a27;
    public GameObject _0x40dabef1
    {
        get
        {
            return this._0x77c8fc94;
        }
    }

    private GameObject _0x77c8fc94;
}

internal static class _0x8b01c1ae
{
    internal static string _0xc59d06a1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}