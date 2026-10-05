using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x295b4343 : MonoBehaviour
{
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xf946dae6(Object _0x91902495)
    {
        TMP_Text _0xce2c4eee = _0x91902495 as TMP_Text;
        if (_0xce2c4eee != null)
            this._0xf73a7aaa.Add(_0xce2c4eee);
    }

    private const float MinOutlineWidth = 0.01f;
    private const float MinRatio = 4.5f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x4d79a176)
    {
        return 0.2126f * Linear(_0x4d79a176.r) + 0.7152f * Linear(_0x4d79a176.g) + 0.0722f * Linear(_0x4d79a176.b);
    }

    private void OnEnable()
    {
        if (this._0xa0831cfc == null)
            this._0xa0831cfc = _0xfbe18e9b => this._0xf946dae6(_0xfbe18e9b);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xa0831cfc);
    }

    private static float Linear(float _0x9d5d0e03)
    {
        _0x9d5d0e03 = Mathf.Clamp01(_0x9d5d0e03);
        return _0x9d5d0e03 <= 0.03928f ? _0x9d5d0e03 / 12.92f : Mathf.Pow((_0x9d5d0e03 + 0.055f) / 1.055f, 2.4f);
    }

    private readonly HashSet<TMP_Text> _0xf73a7aaa = new HashSet<TMP_Text>();
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x609edfaa != null)
            return;
        GameObject _0xc4164124 = new GameObject(_0x8ea53099._0x44068de0(new byte[16] { 148, 173, 176, 131, 175, 174, 180, 178, 161, 179, 180, 135, 181, 161, 178, 164 }, 192));
        _0xc4164124.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xc4164124);
        _0x609edfaa = _0xc4164124.AddComponent<_0x295b4343>();
    }

    private void OnDisable()
    {
        if (this._0xa0831cfc != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xa0831cfc);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xa0831cfc;
    private readonly List<TMP_Text> _0x41f290b2 = new List<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0xf73a7aaa.Count == 0)
            return;
        this._0x41f290b2.Clear();
        this._0x41f290b2.AddRange(this._0xf73a7aaa);
        this._0xf73a7aaa.Clear();
        for (int _0x7d8c854f = 0; _0x7d8c854f < this._0x41f290b2.Count; _0x7d8c854f++)
            Fix(this._0x41f290b2[_0x7d8c854f]);
    }

    private static void Fix(TMP_Text _0x936497db)
    {
        if (_0x936497db == null || !_0x936497db.isActiveAndEnabled)
            return;
        Material _0x047e1cb4 = _0x936497db.fontSharedMaterial;
        if (_0x047e1cb4 == null || !_0x047e1cb4.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x047e1cb4.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x047e1cb4.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xc1f5470c = _0x936497db.color;
        if (_0xc1f5470c.a <= 0f)
            return;
        Color _0x609acb8e = _0x047e1cb4.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xc1f5470c, _0x609acb8e) >= MinRatio)
            return;
        Color _0x63088d6d = Luminance(_0x609acb8e) < 0.5f ? Color.white : Color.black;
        Color _0x8159f964;
        if (Ratio(_0x63088d6d, _0x609acb8e) < TargetRatio)
        {
            _0x8159f964 = _0x63088d6d;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xcea0f94c = 0f;
            float _0xc4727d8f = 1f;
            for (int _0x64175c68 = 0; _0x64175c68 < 20; _0x64175c68++)
            {
                float _0x5a7eb067 = (_0xcea0f94c + _0xc4727d8f) * 0.5f;
                if (Ratio(Color.Lerp(_0xc1f5470c, _0x63088d6d, _0x5a7eb067), _0x609acb8e) >= TargetRatio)
                    _0xc4727d8f = _0x5a7eb067;
                else
                    _0xcea0f94c = _0x5a7eb067;
            }

            _0x8159f964 = Color.Lerp(_0xc1f5470c, _0x63088d6d, _0xc4727d8f);
        }

        _0x8159f964.a = _0xc1f5470c.a;
        _0x936497db.color = _0x8159f964;
    }

    private static _0x295b4343 _0x609edfaa;
    private const float TargetRatio = 7f;
    private static float Ratio(Color _0x20e52889, Color _0x1c5dc1a5)
    {
        float _0x7a8219df = Luminance(_0x20e52889);
        float _0x64810111 = Luminance(_0x1c5dc1a5);
        return (Mathf.Max(_0x7a8219df, _0x64810111) + 0.05f) / (Mathf.Min(_0x7a8219df, _0x64810111) + 0.05f);
    }
}

internal static class _0x8ea53099
{
    internal static string _0x44068de0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}