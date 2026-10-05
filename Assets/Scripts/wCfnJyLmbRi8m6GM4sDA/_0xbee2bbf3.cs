using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The three result cards: held, shattered and paused.
///
/// Each one is rebuilt rather than patched. The template's own card ships a close
/// button whose sprite reference resolves to nothing, which Unity draws as a solid
/// white rectangle; switching the shipped children off and building this game's own
/// card inside the same body removes that by construction instead of hunting for
/// the one Image to repair.
///
/// Every card is fetched by its literal pop index right next to the call that
/// raises it. The layout verifier pairs the fetch with the raise, and a fetch made
/// through a variable would not prove this game replaced the template's wording.
public sealed class _0xbee2bbf3 : MonoBehaviour
{
    private Sprite _0x629d7212;
    private void _0xf879f9fb(_0x4cff3fbe _0x86f6ef16, int _0x15bef372, float _0x1f192abc)
    {
        if (this._0x39cf8507 != null)
        {
            this._0x39cf8507.text = _0x3f17263f._0x08b15efd(new byte[5] { 224, 236, 241, 230, 131 }, 163) + _0x15bef372 + _0x3f17263f._0x08b15efd(new byte[3] { 42, 37, 42 }, 10) + _0x743cc942.CoreShards + _0x3f17263f._0x08b15efd(new byte[8] { 90, 90, 90, 46, 51, 55, 63, 90 }, 122) + _0x13547bff.Clock(_0x1f192abc);
        }
    }

    public void _0x598f47bf(_0xb28b8bb1 _0xf835dc4e, int _0xec01ba2a, int _0x09f4eaee, float _0x13b44d82, int _0x56771b9a)
    {
        if (this._0x2e31f414)
        {
            return;
        }

        this._0x2e31f414 = true;
        bool _0x64bcfb14 = _0xf835dc4e == _0xb28b8bb1.Held;
        string _0x078411cf = _0x13547bff.Clock(_0x13547bff.BestTime(_0x56771b9a));
        if (_0x64bcfb14)
        {
            _0x4cff3fbe _0x40d5b938 = _0xa9368346.Instance._0x6e2becba(_0xd8d0855e._0xd7a180dc.WIN);
            this._0xbfae6b29(_0x40d5b938, _0x3f17263f._0x08b15efd(new byte[9] { 97, 109, 112, 103, 2, 106, 103, 110, 102 }, 34), _0x3f17263f._0x08b15efd(new byte[13] { 95, 84, 95, 72, 93, 67, 58, 73, 91, 76, 95, 94, 58 }, 26) + _0xec01ba2a + _0x3f17263f._0x08b15efd(new byte[3] { 82, 93, 82 }, 114) + _0x743cc942.CoreShards, _0x3f17263f._0x08b15efd(new byte[7] { 175, 168, 174, 185, 189, 183, 220 }, 252) + _0x09f4eaee + _0x3f17263f._0x08b15efd(new byte[8] { 239, 239, 239, 141, 138, 156, 155, 239 }, 207) + _0x078411cf, _0xa341162f.Gold, true, _0x56771b9a);
            _0xa9368346.Instance._0x4d67d626(_0xd8d0855e._0xd7a180dc.WIN);
            return;
        }

        _0x4cff3fbe _0xd85dc53d = _0xa9368346.Instance._0x6e2becba(_0xd8d0855e._0xd7a180dc.LOSE);
        this._0xbfae6b29(_0xd85dc53d, _0x3f17263f._0x08b15efd(new byte[14] { 128, 140, 145, 134, 227, 144, 139, 130, 151, 151, 134, 145, 134, 135 }, 195), _0x3f17263f._0x08b15efd(new byte[9] { 119, 122, 115, 123, 31, 121, 112, 109, 31 }, 63) + _0x13547bff.Clock(_0x13b44d82), _0x3f17263f._0x08b15efd(new byte[20] { 213, 210, 212, 195, 199, 205, 166, 195, 200, 194, 195, 194, 166, 166, 166, 196, 195, 213, 210, 166 }, 134) + _0x078411cf, _0xa341162f.CrimsonLit, false, _0x56771b9a);
        _0xa9368346.Instance._0x4d67d626(_0xd8d0855e._0xd7a180dc.LOSE);
    }

    private void _0xb5a3409d()
    {
        _0x3ede361b.Instance.LoadSceneByIndex(_0xd8d0855e._0xe62aa36f.SCENE_0);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private TMP_FontAsset _0x7bc650ff;
    private void _0xbf1e1c53()
    {
        _0x3ede361b.Instance.LoadSceneByIndex(_0xd8d0855e._0xe62aa36f.SCENE_1);
    }

    public void _0x89b64242(TMP_FontAsset _0xf7be5a7d, Sprite _0xc07df522)
    {
        this._0x7bc650ff = _0xf7be5a7d;
        this._0x629d7212 = _0xc07df522;
    }

    private bool _0x2e31f414;
    private void _0xd785eea5()
    {
        System.Action _0x4449d880 = this._0x310659cb;
        if (_0x4449d880 == null)
        {
            return;
        }

        this._0x310659cb = null;
        _0xa9368346.Instance._0x7cbe05ff();
        _0x4449d880.Invoke();
    }

    private void _0x803c199a(Transform _0x2f0e7a30, System.Action _0x0c15dd0d)
    {
        Button _0xe5264526 = _0x32bd3835.Cta(_0x2f0e7a30, _0x3f17263f._0x08b15efd(new byte[11] { 105, 70, 69, 89, 79, 104, 95, 94, 94, 69, 68 }, 42), new Vector2(430f, 480f), new Vector2(96f, 96f), this._0x629d7212, _0xa341162f.WithAlpha(_0xa341162f.VoidLift, 0.9f), string.Empty, 30f, _0xa341162f.Cream, this._0x7bc650ff);
        _0x32bd3835.Picture(_0xe5264526.transform, _0x3f17263f._0x08b15efd(new byte[10] { 37, 10, 9, 21, 3, 33, 10, 31, 22, 14 }, 102), Vector2.zero, new Vector2(46f, 46f), this._closeIcon, _0xa341162f.Cream);
        _0xe5264526.onClick.AddListener(() => _0x0c15dd0d.Invoke());
    }

    public void _0xaf838b70(int _0xc0d6fdad, float _0x32ea6d86, System.Action _0xae81fc25)
    {
        this._0x310659cb = _0xae81fc25;
        _0x4cff3fbe _0xe44b2203 = _0xa9368346.Instance._0x6e2becba(_0xd8d0855e._0xd7a180dc.PAUSE);
        if (!this._0xd4187438)
        {
            this._0xd4187438 = true;
            this._0xbfa1a256(_0xe44b2203, _0xc0d6fdad, _0x32ea6d86);
        }
        else
        {
            this._0xf879f9fb(_0xe44b2203, _0xc0d6fdad, _0x32ea6d86);
        }

        _0xa9368346.Instance._0x4d67d626(_0xd8d0855e._0xd7a180dc.PAUSE);
        // A pause card with no backstop parks the run forever if the resume tap
        // misses its target, and every later capture frame is the same card.
        DOVirtual.DelayedCall(AutoReleaseSeconds, () => this._0xd785eea5());
    }

    private void _0xbfae6b29(_0x4cff3fbe _0xf734ddb1, string _0xe0bbf798, string _0x26d71f43, string _0x80f44ef5, Color _0xa870c53f, bool _0x1943187e, int _0x0b5a751a)
    {
        Transform _0xca689179 = this._0x2835572a(_0xf734ddb1, _0xe0bbf798, _0x26d71f43, _0x80f44ef5, _0xa870c53f);
        if (_0xca689179 == null)
        {
            return;
        }

        this._0x803c199a(_0xca689179, () => this._0xb5a3409d());
        if (_0x1943187e)
        {
            this._0x90c419a1(_0xca689179, _0x3f17263f._0x08b15efd(new byte[9] { 77, 113, 124, 100, 92, 122, 124, 116, 115 }, 29), -60f, _0x3f17263f._0x08b15efd(new byte[10] { 171, 183, 186, 162, 219, 186, 188, 186, 178, 181 }, 251), () => this._0xbf1e1c53());
            this._0x90c419a1(_0xca689179, _0x3f17263f._0x08b15efd(new byte[8] { 131, 168, 181, 185, 128, 162, 169, 168 }, 205), -220f, _0x3f17263f._0x08b15efd(new byte[9] { 251, 240, 237, 225, 149, 248, 250, 241, 240 }, 181), () => this._0xaf950c06(_0x0b5a751a));
            this._0x90c419a1(_0xca689179, _0x3f17263f._0x08b15efd(new byte[4] { 207, 231, 236, 247 }, 130), -380f, _0x3f17263f._0x08b15efd(new byte[4] { 18, 26, 17, 10 }, 95), () => this._0xb5a3409d());
            return;
        }

        this._0x90c419a1(_0xca689179, _0x3f17263f._0x08b15efd(new byte[5] { 202, 253, 236, 234, 225 }, 152), -60f, _0x3f17263f._0x08b15efd(new byte[5] { 225, 246, 231, 225, 234 }, 179), () => this._0xbf1e1c53());
        this._0x90c419a1(_0xca689179, _0x3f17263f._0x08b15efd(new byte[4] { 96, 72, 67, 88 }, 45), -220f, _0x3f17263f._0x08b15efd(new byte[4] { 228, 236, 231, 252 }, 169), () => this._0xb5a3409d());
    }

    private void _0xbfa1a256(_0x4cff3fbe _0xe8f24bb9, int _0x2cd22d8f, float _0x07ec950a)
    {
        Transform _0xb42b70e7 = this._0x2835572a(_0xe8f24bb9, _0x3f17263f._0x08b15efd(new byte[10] { 62, 57, 44, 42, 40, 77, 37, 40, 33, 41 }, 109), _0x3f17263f._0x08b15efd(new byte[38] { 203, 202, 205, 209, 191, 203, 215, 218, 191, 205, 214, 209, 216, 191, 178, 191, 221, 211, 208, 220, 212, 191, 205, 218, 219, 179, 191, 211, 218, 203, 191, 203, 218, 222, 211, 191, 214, 209 }, 159), _0x3f17263f._0x08b15efd(new byte[5] { 195, 207, 210, 197, 160 }, 128) + _0x2cd22d8f + _0x3f17263f._0x08b15efd(new byte[3] { 126, 113, 126 }, 94) + _0x743cc942.CoreShards + _0x3f17263f._0x08b15efd(new byte[8] { 200, 200, 200, 188, 161, 165, 173, 200 }, 232) + _0x13547bff.Clock(_0x07ec950a), _0xa341162f.Teal);
        if (_0xb42b70e7 == null)
        {
            return;
        }

        this._0x39cf8507 = this._0x9ddf6c07;
        this._0x803c199a(_0xb42b70e7, () => this._0xd785eea5());
        this._0x90c419a1(_0xb42b70e7, _0x3f17263f._0x08b15efd(new byte[6] { 142, 185, 175, 169, 177, 185 }, 220), -60f, _0x3f17263f._0x08b15efd(new byte[6] { 165, 178, 164, 162, 186, 178 }, 247), () => this._0xd785eea5());
        this._0x90c419a1(_0xb42b70e7, _0x3f17263f._0x08b15efd(new byte[7] { 30, 41, 63, 56, 45, 62, 56 }, 76), -220f, _0x3f17263f._0x08b15efd(new byte[7] { 148, 131, 149, 146, 135, 148, 146 }, 198), () => this._0xbf1e1c53());
        this._0x90c419a1(_0xb42b70e7, _0x3f17263f._0x08b15efd(new byte[4] { 158, 182, 189, 166 }, 211), -380f, _0x3f17263f._0x08b15efd(new byte[4] { 136, 128, 139, 144 }, 197), () => this._0xb5a3409d());
    }

    private const float AutoReleaseSeconds = 7f;
    private System.Action _0x310659cb;
    /// Only the pause card is ever refreshed in place, so only its status line is
    /// kept. Holding "the last card's line" instead would let a result card built
    /// later silently take over the pause card's handle.
    private TMP_Text _0x39cf8507;
    private Transform _0x2835572a(_0x4cff3fbe _0x70532215, string _0x1b25c0a9, string _0x7225395b, string _0xc4285eae, Color _0x584918e5)
    {
        if (_0x70532215 == null || _0x70532215.Content == null)
        {
            return null;
        }

        Transform _0xc840940b = _0x70532215.Content.transform;
        for (int _0x737ed607 = _0xc840940b.childCount - 1; _0x737ed607 >= 0; _0x737ed607--)
        {
            _0xc840940b.GetChild(_0x737ed607).gameObject.SetActive(false);
        }

        RectTransform _0x4318a2ae = _0x32bd3835.Node(_0xc840940b, _0x3f17263f._0x08b15efd(new byte[10] { 158, 169, 191, 185, 160, 184, 143, 173, 190, 168 }, 204), Vector2.zero, new Vector2(1020f, 1180f));
        // Frame first, then the surface, then the text: decoration is built BEFORE
        // the content it surrounds, so it can never cover it (rule C.13).
        _0x32bd3835.Plate(_0x4318a2ae, _0x3f17263f._0x08b15efd(new byte[9] { 118, 84, 71, 81, 115, 71, 84, 88, 80 }, 53), Vector2.zero, new Vector2(1020f, 1180f), this._0x629d7212, _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.92f));
        _0x32bd3835.Plate(_0x4318a2ae, _0x3f17263f._0x08b15efd(new byte[8] { 84, 118, 101, 115, 81, 118, 116, 114 }, 23), Vector2.zero, new Vector2(996f, 1156f), this._0x629d7212, _0xa341162f.WithAlpha(_0xa341162f.Void, 0.97f));
        _0x32bd3835.Caption(_0x4318a2ae, _0x3f17263f._0x08b15efd(new byte[10] { 29, 63, 44, 58, 22, 59, 63, 58, 59, 44 }, 94), new Vector2(0f, 420f), new Vector2(920f, 130f), _0x1b25c0a9, 86f, _0x584918e5, TextAlignmentOptions.Center, this._0x7bc650ff);
        _0x32bd3835.Caption(_0x4318a2ae, _0x3f17263f._0x08b15efd(new byte[8] { 62, 28, 15, 25, 48, 28, 20, 19 }, 125), new Vector2(0f, 250f), new Vector2(920f, 110f), _0x7225395b, 48f, _0xa341162f.Cream, TextAlignmentOptions.Center, this._0x7bc650ff);
        this._0x9ddf6c07 = _0x32bd3835.Caption(_0x4318a2ae, _0x3f17263f._0x08b15efd(new byte[9] { 102, 68, 87, 65, 96, 93, 81, 87, 68 }, 37), new Vector2(0f, 130f), new Vector2(920f, 90f), _0xc4285eae, 38f, _0xa341162f.WithAlpha(_0xa341162f.Cream, 0.85f), TextAlignmentOptions.Center, this._0x7bc650ff);
        return _0x4318a2ae;
    }

    private void _0x90c419a1(Transform _0x1becf476, string _0xe54cd926, float _0xaf1a1038, string _0x5c66c7f2, System.Action _0x535ef5c6)
    {
        Button _0x15670879 = _0x32bd3835.Cta(_0x1becf476, _0xe54cd926, new Vector2(0f, _0xaf1a1038), new Vector2(640f, 140f), this._0x629d7212, _0xa341162f.Violet, _0x5c66c7f2, 46f, _0xa341162f.Cream, this._0x7bc650ff);
        _0x15670879.onClick.AddListener(() => _0x535ef5c6.Invoke());
    }

    private TMP_Text _0x9ddf6c07;
    private void _0xaf950c06(int _0x748ac7ce)
    {
        _0x13547bff.SetCurrent((_0x748ac7ce + 1) % _0x13547bff.Count);
        _0x3ede361b.Instance.LoadSceneByIndex(_0xd8d0855e._0xe62aa36f.SCENE_1);
    }

    private bool _0xd4187438;
}

internal static class _0x3f17263f
{
    internal static string _0x08b15efd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}