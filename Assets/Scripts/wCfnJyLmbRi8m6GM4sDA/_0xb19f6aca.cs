using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// The living preview on the menu: the crystal, the guard ring turning slowly, and
/// four pulses walking in along their lanes.
///
/// It is also the honest half of rule C.7 - picking a mode changes the speed HERE,
/// so the choice is visible as motion and not only as a changed caption.
public sealed class _0xb19f6aca : MonoBehaviour
{
    private float _0xef52f599 = 1f;
    private float _0xd5163c17;
    private RectTransform _0x50dd3f53;
    private float _0xb20a5083;
    private const float RingSeconds = 9f;
    private void Update()
    {
        if (this._0xf361962a.Count == 0)
        {
            return;
        }

        this._0xb20a5083 += Time.deltaTime * this._0xef52f599;
        float _0x8dcbdd9f = Mathf.Repeat(this._0xb20a5083, PulseCycleSeconds) / PulseCycleSeconds;
        for (int _0x6d058edb = 0; _0x6d058edb < this._0xf361962a.Count; _0x6d058edb++)
        {
            RectTransform _0x7dfd9a4c = this._0xf361962a[_0x6d058edb];
            if (_0x7dfd9a4c == null)
            {
                continue;
            }

            float _0x7a541c82 = Mathf.Repeat(_0x8dcbdd9f + (_0x6d058edb * 0.25f), 1f);
            bool _0xfe4b09eb = this._0x48b9fe53[_0x6d058edb];
            // A hazard walks in, meets a solid sector and is thrown back out; a
            // charge keeps going until it reaches the crystal.
            float _0xf7001659 = _0xfe4b09eb ? (_0x7a541c82 < 0.6f ? _0x7a541c82 / 0.6f : 1f - ((_0x7a541c82 - 0.6f) / 0.4f)) : _0x7a541c82;
            float _0xad7c1048 = Mathf.Lerp(this._0x01f79092, _0xfe4b09eb ? this._0xd5163c17 + 40f : 0f, _0xf7001659);
            float _0x39ee2f83 = 90f * _0x6d058edb;
            float _0x07f53e48 = _0x39ee2f83 * Mathf.Deg2Rad;
            _0x7dfd9a4c.anchoredPosition = new Vector2(Mathf.Cos(_0x07f53e48) * _0xad7c1048, Mathf.Sin(_0x07f53e48) * _0xad7c1048);
        }
    }

    private readonly List<RectTransform> _0xf361962a = new List<RectTransform>();
    private const float PulseCycleSeconds = 3.4f;
    public void Build(Transform _0x88cc4a20, Sprite _0x4f0dd638, Sprite _0x543c7962, Sprite _0x28d54951, Sprite _0x12ef6f3e, Sprite _0x19a94c2d, Sprite _0x8b4c09c8)
    {
        this._0x01f79092 = 370f;
        this._0xd5163c17 = 150f;
        _0x32bd3835.Picture(_0x88cc4a20, _0x967f3497._0xc38acd41(new byte[11] { 228, 198, 209, 194, 221, 209, 195, 243, 216, 219, 195 }, 180), Vector2.zero, new Vector2(820f, 820f), _0x8b4c09c8, _0xa341162f.WithAlpha(_0xa341162f.Violet, 0.40f));
        this._0x50dd3f53 = _0x32bd3835.Node(_0x88cc4a20, _0x967f3497._0xc38acd41(new byte[11] { 128, 162, 181, 166, 185, 181, 167, 130, 185, 190, 183 }, 208), Vector2.zero, new Vector2(740f, 740f));
        _0x32bd3835.Picture(this._0x50dd3f53, _0x967f3497._0xc38acd41(new byte[14] { 135, 165, 178, 161, 190, 178, 160, 133, 190, 185, 176, 150, 165, 163 }, 215), Vector2.zero, new Vector2(740f, 740f), _0x4f0dd638, _0xa341162f.Violet);
        _0x32bd3835.Picture(this._0x50dd3f53, _0x967f3497._0xc38acd41(new byte[14] { 88, 122, 109, 126, 97, 109, 127, 79, 105, 124, 109, 73, 122, 124 }, 8), Vector2.zero, new Vector2(740f, 740f), _0x543c7962, _0xa341162f.Teal);
        _0x32bd3835.Picture(_0x88cc4a20, _0x967f3497._0xc38acd41(new byte[14] { 100, 70, 81, 66, 93, 81, 67, 119, 70, 77, 71, 64, 85, 88 }, 52), Vector2.zero, new Vector2(300f, 300f), _0x28d54951, _0xa341162f.Gold);
        // Two hazards and two charges, one per lane, so the preview shows both
        // outcomes of the rule at once.
        for (int _0xc4455664 = 0; _0xc4455664 < 4; _0xc4455664++)
        {
            bool _0x48653ecf = _0xc4455664 % 2 == 0;
            RectTransform _0xaf58968f = _0x32bd3835.Node(_0x88cc4a20, _0x967f3497._0xc38acd41(new byte[12] { 182, 148, 131, 144, 143, 131, 145, 182, 147, 138, 149, 131 }, 230), Vector2.zero, new Vector2(96f, 96f));
            Image _0xfa73f2a2 = _0xaf58968f.gameObject.AddComponent<Image>();
            _0xfa73f2a2.sprite = _0x48653ecf ? _0x12ef6f3e : _0x19a94c2d;
            _0xfa73f2a2.preserveAspect = true;
            _0xfa73f2a2.raycastTarget = false;
            _0xfa73f2a2.color = _0x48653ecf ? _0xa341162f.Crimson : _0xa341162f.Teal;
            this._0xf361962a.Add(_0xaf58968f);
            this._0x48b9fe53.Add(_0x48653ecf);
        }

        this._0x50dd3f53.DOKill();
        this._0x50dd3f53.DOLocalRotate(new Vector3(0f, 0f, -360f), RingSeconds, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }

    public void _0x0dec4724(float _0xcff50744)
    {
        this._0xef52f599 = Mathf.Max(0.1f, _0xcff50744);
    }

    private float _0x01f79092;
    private readonly List<bool> _0x48b9fe53 = new List<bool>();
}

internal static class _0x967f3497
{
    internal static string _0xc38acd41(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}