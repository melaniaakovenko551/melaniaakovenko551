using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Rewrites the two tutorial pages this game actually uses.
///
/// The template's pages are left in the pool (the controller indexes them) but
/// their shipped content is switched off and replaced, because a tutorial carrying
/// another game's words is worse than no tutorial at all.
///
/// The automatic first-run tutorial stays OFF. It is gated on a PlayerPrefs flag,
/// so it would appear on a fresh install and not on the next launch - and the
/// review capture force-stops and relaunches, which would then photograph two
/// different flows. A button in the menu gives the same pages deterministically.
public sealed class _0x4e45ebf6 : MonoBehaviour
{
    private bool _0xfeed7780;
    public void Build(TMP_FontAsset _0x07186241, Sprite _0xea00f7c2, Sprite _0xc7979129, Sprite _0x4e486f26, Sprite _0x4cc31f2e, Sprite _0xa0e0bbc6, Sprite _0xbc2fb269, Sprite _0xd2d38548)
    {
        if (this._0xfeed7780)
        {
            return;
        }

        this._0xfeed7780 = true;
        this._0xc48fe6bd = _0x07186241;
        this._0x6e2132e0 = _0xea00f7c2;
        this._0x6f9009b3(_0xc7979129, _0x4e486f26, _0xbc2fb269);
        this._0xa58b189b(_0xc7979129, _0x4e486f26, _0x4cc31f2e, _0xa0e0bbc6, _0xd2d38548);
    }

    private void _0x6f9009b3(Sprite _0xb6af4d6c, Sprite _0x35398abf, Sprite _0x9271cb5f)
    {
        Transform _0x1367c1ca = this._0x145c52a6(_0xd8d0855e._0x1a8d0e5d.TUTORIAL0);
        if (_0x1367c1ca == null)
        {
            return;
        }

        Image _0x7d3abf2b = _0x1367c1ca.gameObject.AddComponent<Image>();
        _0x7d3abf2b.color = _0xa341162f.WithAlpha(_0xa341162f.VoidDeep, 0.9f);
        _0x7d3abf2b.raycastTarget = true;
        _0x32bd3835.Caption(_0x1367c1ca, _0xfdac9aac._0x866706f6(new byte[10] { 170, 141, 149, 182, 141, 182, 139, 150, 142, 135 }, 226), _0x32bd3835.FromTop(621f, 560f), new Vector2(960f, 130f), _0xfdac9aac._0x866706f6(new byte[13] { 252, 253, 250, 230, 136, 252, 224, 237, 136, 250, 225, 230, 239 }, 168), 72f, _0xa341162f.Gold, TextAlignmentOptions.Center, this._0xc48fe6bd);
        RectTransform _0x1e0f0ff5 = _0x32bd3835.Node(_0x1367c1ca, _0xfdac9aac._0x866706f6(new byte[8] { 194, 229, 253, 222, 229, 203, 248, 254 }, 138), _0x32bd3835.FromTop(621f, 1060f), new Vector2(620f, 620f));
        _0x32bd3835.Picture(_0x1e0f0ff5, _0xfdac9aac._0x866706f6(new byte[9] { 101, 66, 90, 121, 66, 127, 68, 67, 74 }, 45), Vector2.zero, new Vector2(560f, 560f), _0xb6af4d6c, _0xa341162f.Violet);
        _0x32bd3835.Picture(_0x1e0f0ff5, _0xfdac9aac._0x866706f6(new byte[9] { 187, 156, 132, 167, 156, 180, 146, 135, 150 }, 243), Vector2.zero, new Vector2(560f, 560f), _0x35398abf, _0xa341162f.Teal);
        _0x32bd3835.Picture(_0x1e0f0ff5, _0xfdac9aac._0x866706f6(new byte[13] { 40, 15, 23, 52, 15, 52, 21, 18, 14, 40, 9, 14, 20 }, 96), new Vector2(0f, -40f), new Vector2(240f, 240f), _0x9271cb5f, _0xa341162f.Cream);
        _0x32bd3835.Caption(_0x1367c1ca, _0xfdac9aac._0x866706f6(new byte[9] { 205, 234, 242, 209, 234, 199, 234, 225, 252 }, 133), _0x32bd3835.FromTop(621f, 1560f), new Vector2(1000f, 200f), _0xfdac9aac._0x866706f6(new byte[55] { 14, 27, 10, 122, 14, 15, 8, 20, 122, 22, 31, 28, 14, 122, 21, 8, 122, 14, 15, 8, 20, 122, 8, 19, 29, 18, 14, 116, 80, 14, 18, 31, 122, 8, 19, 20, 29, 122, 9, 20, 27, 10, 9, 122, 99, 106, 122, 30, 31, 29, 8, 31, 31, 9, 116 }, 90), 46f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._0xc48fe6bd);
        Button _0xd318c30a = _0x32bd3835.Cta(_0x1367c1ca, _0xfdac9aac._0x866706f6(new byte[9] { 208, 247, 239, 204, 247, 214, 253, 224, 236 }, 152), _0x32bd3835.FromTop(621f, 1980f), new Vector2(640f, 150f), this._0x6e2132e0, _0xa341162f.Violet, _0xfdac9aac._0x866706f6(new byte[4] { 76, 71, 90, 86 }, 2), 48f, _0xa341162f.Cream, this._0xc48fe6bd);
        _0xd318c30a.onClick.AddListener(() => this._0x5fecf041());
    }

    private void _0xa58b189b(Sprite _0x32c40bd3, Sprite _0x95a9509c, Sprite _0xea33ae7e, Sprite _0x73901042, Sprite _0xed57c4fe)
    {
        Transform _0xf78120f3 = this._0x145c52a6(_0xd8d0855e._0x1a8d0e5d.TUTORIAL1);
        if (_0xf78120f3 == null)
        {
            return;
        }

        Image _0x5671f0b0 = _0xf78120f3.gameObject.AddComponent<Image>();
        _0x5671f0b0.color = _0xa341162f.WithAlpha(_0xa341162f.VoidDeep, 0.9f);
        _0x5671f0b0.raycastTarget = true;
        _0x32bd3835.Caption(_0xf78120f3, _0xfdac9aac._0x866706f6(new byte[10] { 126, 89, 65, 98, 89, 98, 95, 66, 90, 83 }, 54), _0x32bd3835.FromTop(621f, 560f), new Vector2(960f, 130f), _0xfdac9aac._0x866706f6(new byte[14] { 223, 209, 210, 222, 214, 189, 220, 211, 217, 189, 205, 220, 206, 206 }, 157), 72f, _0xa341162f.Teal, TextAlignmentOptions.Center, this._0xc48fe6bd);
        RectTransform _0x5877b7c3 = _0x32bd3835.Node(_0xf78120f3, _0xfdac9aac._0x866706f6(new byte[8] { 24, 63, 39, 4, 63, 17, 34, 36 }, 80), _0x32bd3835.FromTop(621f, 1060f), new Vector2(620f, 620f));
        _0x32bd3835.Picture(_0x5877b7c3, _0xfdac9aac._0x866706f6(new byte[9] { 242, 213, 205, 238, 213, 232, 211, 212, 221 }, 186), Vector2.zero, new Vector2(560f, 560f), _0x32c40bd3, _0xa341162f.Violet);
        _0x32bd3835.Picture(_0x5877b7c3, _0xfdac9aac._0x866706f6(new byte[9] { 154, 189, 165, 134, 189, 149, 179, 166, 183 }, 210), Vector2.zero, new Vector2(560f, 560f), _0x95a9509c, _0xa341162f.Teal);
        _0x32bd3835.Picture(_0x5877b7c3, _0xfdac9aac._0x866706f6(new byte[12] { 109, 74, 82, 113, 74, 102, 87, 92, 86, 81, 68, 73 }, 37), Vector2.zero, new Vector2(180f, 180f), _0xed57c4fe, _0xa341162f.Gold);
        _0x32bd3835.Picture(_0x5877b7c3, _0xfdac9aac._0x866706f6(new byte[11] { 55, 16, 8, 43, 16, 55, 30, 5, 30, 13, 27 }, 127), new Vector2(-250f, 0f), new Vector2(110f, 110f), _0xea33ae7e, _0xa341162f.Crimson);
        _0x32bd3835.Picture(_0x5877b7c3, _0xfdac9aac._0x866706f6(new byte[11] { 45, 10, 18, 49, 10, 38, 13, 4, 23, 2, 0 }, 101), new Vector2(0f, 250f), new Vector2(110f, 110f), _0x73901042, _0xa341162f.Teal);
        _0x32bd3835.Caption(_0xf78120f3, _0xfdac9aac._0x866706f6(new byte[9] { 222, 249, 225, 194, 249, 212, 249, 242, 239 }, 150), _0x32bd3835.FromTop(621f, 1560f), new Vector2(1000f, 220f), _0xfdac9aac._0x866706f6(new byte[65] { 164, 184, 187, 190, 179, 215, 164, 178, 180, 163, 184, 165, 164, 215, 181, 184, 162, 185, 180, 178, 215, 165, 178, 179, 217, 253, 163, 191, 178, 215, 184, 167, 178, 185, 215, 176, 182, 163, 178, 215, 187, 178, 163, 164, 215, 163, 178, 182, 187, 253, 165, 178, 182, 180, 191, 215, 163, 191, 178, 215, 180, 184, 165, 178, 217 }, 247), 46f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._0xc48fe6bd);
        Button _0xb1605b93 = _0x32bd3835.Cta(_0xf78120f3, _0xfdac9aac._0x866706f6(new byte[9] { 165, 130, 154, 185, 130, 169, 130, 131, 136 }, 237), _0x32bd3835.FromTop(621f, 1980f), new Vector2(680f, 150f), this._0x6e2132e0, _0xa341162f.Violet, _0xfdac9aac._0x866706f6(new byte[13] { 150, 145, 132, 151, 145, 229, 149, 137, 132, 156, 140, 139, 130 }, 197), 48f, _0xa341162f.Cream, this._0xc48fe6bd);
        _0xb1605b93.onClick.AddListener(() => this._0xdf452cc7());
    }

    private Sprite _0x6e2132e0;
    private void _0xdf452cc7()
    {
        _0x4895092e.Instance._0xe77504a1(_0xd8d0855e._0x1a8d0e5d.DEFAULT);
    }

    private TMP_FontAsset _0xc48fe6bd;
    private void _0x5fecf041()
    {
        _0x4895092e.Instance._0xe77504a1(_0xd8d0855e._0x1a8d0e5d.TUTORIAL1);
    }

    private Transform _0x145c52a6(int _0xf672ec82)
    {
        Transform _0xa8746c4c = _0x2eb0f825.PanelBody(_0xf672ec82);
        if (_0xa8746c4c == null)
        {
            return null;
        }

        for (int _0xfef9a9dd = _0xa8746c4c.childCount - 1; _0xfef9a9dd >= 0; _0xfef9a9dd--)
        {
            _0xa8746c4c.GetChild(_0xfef9a9dd).gameObject.SetActive(false);
        }

        return _0x32bd3835.Stretch(_0xa8746c4c, _0xfdac9aac._0x866706f6(new byte[9] { 172, 139, 147, 176, 139, 180, 133, 131, 129 }, 228));
    }
}

internal static class _0xfdac9aac
{
    internal static string _0x866706f6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}