using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The in-run HUD, built from this game's own objects rather than the template's
/// slots: timer, shard column, charge meter, the permanent control hint and the
/// mode label.
///
/// Rule C.25 is satisfied by construction - the CORE and CHARGE captions sit ABOVE
/// their indicator columns, so no caption shares a horizontal band with a row of
/// pips and nothing can collide at a different text length.
public sealed class _0xc05d9497 : MonoBehaviour
{
    public void _0x9409cad2(int _0x313f0090, int _0x6363fb61, float _0xc5827482)
    {
        if (this._0x9d8a6eab != null)
        {
            this._0x9d8a6eab.text = _0x13547bff.Clock(_0xc5827482);
        }

        if (_0x313f0090 != this._0xb9d888ad)
        {
            this._0xb9d888ad = _0x313f0090;
            for (int _0xcdc7dbae = 0; _0xcdc7dbae < this._0xba415a8b.Count; _0xcdc7dbae++)
            {
                Image _0xbc2d5ae2 = this._0xba415a8b[_0xcdc7dbae];
                if (_0xbc2d5ae2 == null)
                {
                    continue;
                }

                bool _0x13d796d7 = _0xcdc7dbae < _0x313f0090;
                _0xbc2d5ae2.color = _0x13d796d7 ? _0xa341162f.Gold : _0xa341162f.WithAlpha(_0xa341162f.VoidLift, 0.55f);
            }
        }

        if (_0x6363fb61 != this._0x01776c9b)
        {
            this._0x01776c9b = _0x6363fb61;
            for (int _0x8861c559 = 0; _0x8861c559 < this._0x9d87042f.Count; _0x8861c559++)
            {
                Image _0x3bccebc5 = this._0x9d87042f[_0x8861c559];
                if (_0x3bccebc5 == null)
                {
                    continue;
                }

                bool _0x322c215b = _0x8861c559 < _0x6363fb61;
                _0x3bccebc5.color = _0x322c215b ? _0xa341162f.Teal : _0xa341162f.VoidLift;
                if (_0x322c215b)
                {
                    _0x3bccebc5.transform.DOKill();
                    _0x3bccebc5.transform.localScale = Vector3.one;
                    _0x3bccebc5.transform.DOScale(1.35f, 0.14f).SetLoops(2, LoopType.Yoyo);
                }
            }
        }
    }

    public void Build(Transform _0xd8e1b1e5, TMP_FontAsset _0xcb60e891, Sprite _0x1a63f671, Sprite _0x5b3c13de, int _0xa09b6c6d)
    {
        // Damage veil goes in FIRST so it sits behind every readout (rule C.13).
        RectTransform _0x5eee127e = _0x32bd3835.Stretch(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[10] { 110, 75, 71, 75, 77, 79, 124, 79, 67, 70 }, 42));
        this._0xa1f1321e = _0x5eee127e.gameObject.AddComponent<Image>();
        this._0xa1f1321e.color = _0xa341162f.WithAlpha(_0xa341162f.Crimson, 0f);
        this._0xa1f1321e.raycastTarget = false;
        this._0x9d8a6eab = _0x32bd3835.Caption(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[5] { 18, 47, 43, 35, 52 }, 70), _0x32bd3835.FromTop(621f, 170f), new Vector2(420f, 120f), _0x13547bff.Clock(_0x743cc942.RoundSeconds), 76f, _0xa341162f.Cream, TextAlignmentOptions.Center, _0xcb60e891);
        _0x32bd3835.Caption(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[11] { 49, 29, 0, 23, 49, 19, 2, 6, 27, 29, 28 }, 114), _0x32bd3835.FromTop(150f, 287f), new Vector2(240f, 46f), _0xd727cea7._0xd869c147(new byte[4] { 224, 236, 241, 230 }, 163), 30f, _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.8f), TextAlignmentOptions.Center, _0xcb60e891);
        _0x32bd3835.Caption(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[13] { 124, 87, 94, 77, 88, 90, 124, 94, 79, 75, 86, 80, 81 }, 63), _0x32bd3835.FromTop(1000f, 287f), new Vector2(280f, 46f), _0xd727cea7._0xd869c147(new byte[6] { 243, 248, 241, 226, 247, 245 }, 176), 30f, _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.8f), TextAlignmentOptions.Center, _0xcb60e891);
        for (int _0x1d687f12 = 0; _0x1d687f12 < _0x743cc942.CoreShards; _0x1d687f12++)
        {
            float _0xa66a8bd2 = 74f + (_0x1d687f12 * 84f);
            Image _0x7206984d = _0x32bd3835.Pip(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[8] { 1, 58, 51, 32, 54, 2, 59, 34 }, 82), _0x32bd3835.FromTop(_0xa66a8bd2, 355f), new Vector2(68f, 68f), _0x1a63f671, _0xa341162f.Gold);
            this._0xba415a8b.Add(_0x7206984d);
        }

        for (int _0xd28b24ac = 0; _0xd28b24ac < _0x743cc942.ChargeTarget; _0xd28b24ac++)
        {
            float _0xef5c6ff4 = 820f + (_0xd28b24ac * 56f);
            Image _0x80aa06f4 = _0x32bd3835.Plate(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[13] { 170, 129, 136, 155, 142, 140, 186, 140, 142, 132, 140, 135, 157 }, 233), _0x32bd3835.FromTop(_0xef5c6ff4, 355f), new Vector2(44f, 62f), _0x5b3c13de, _0xa341162f.VoidLift);
            this._0x9d87042f.Add(_0x80aa06f4);
        }

        // Permanent control hint. It sits in the empty band between the arena and
        // the turn buttons, so it explains the control for the whole run without
        // covering anything (rule C.6).
        _0x32bd3835.Plate(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[9] { 8, 41, 46, 52, 16, 44, 33, 52, 37 }, 64), _0x32bd3835.FromTop(621f, 2010f), new Vector2(1060f, 86f), _0x5b3c13de, _0xa341162f.WithAlpha(_0xa341162f.VoidDeep, 0.6f));
        _0x32bd3835.Caption(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[8] { 152, 185, 190, 164, 156, 185, 190, 181 }, 208), _0x32bd3835.FromTop(621f, 2010f), new Vector2(1040f, 70f), _0xd727cea7._0xd869c147(new byte[38] { 147, 146, 149, 137, 231, 147, 143, 130, 231, 149, 142, 137, 128, 231, 234, 231, 133, 139, 136, 132, 140, 231, 149, 130, 131, 235, 231, 139, 130, 147, 231, 147, 130, 134, 139, 231, 142, 137 }, 199), 40f, _0xa341162f.Teal, TextAlignmentOptions.Center, _0xcb60e891);
        _0x32bd3835.Caption(_0xd8e1b1e5, _0xd727cea7._0xd869c147(new byte[8] { 123, 89, 82, 83, 122, 95, 88, 83 }, 54), _0x32bd3835.FromTop(621f, 2092f), new Vector2(700f, 54f), _0xd727cea7._0xd869c147(new byte[5] { 7, 5, 14, 15, 106 }, 74) + _0x13547bff.Title(_0xa09b6c6d), 32f, _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.7f), TextAlignmentOptions.Center, _0xcb60e891);
        this._0x9409cad2(_0x743cc942.CoreShards, 0, _0x743cc942.RoundSeconds);
    }

    private readonly List<Image> _0xba415a8b = new List<Image>();
    private Image _0xa1f1321e;
    private int _0xb9d888ad = -1;
    /// Red wash across the screen edge when a shard breaks - the visible price of
    /// a mistake, which is what makes the run readable in a silent game.
    public void _0x1fbefb20()
    {
        if (this._0xa1f1321e == null)
        {
            return;
        }

        this._0xa1f1321e.DOKill();
        this._0xa1f1321e.color = _0xa341162f.WithAlpha(_0xa341162f.Crimson, 0f);
        Sequence _0x9f8fd2bf = DOTween.Sequence();
        _0x9f8fd2bf.Append(this._0xa1f1321e.DOFade(0.5f, 0.12f));
        _0x9f8fd2bf.Append(this._0xa1f1321e.DOFade(0f, 0.38f));
    }

    private readonly List<Image> _0x9d87042f = new List<Image>();
    private int _0x01776c9b = -1;
    private TextMeshProUGUI _0x9d8a6eab;
}

internal static class _0xd727cea7
{
    internal static string _0xd869c147(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}