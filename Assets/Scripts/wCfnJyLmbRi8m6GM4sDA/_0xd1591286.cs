using TMPro;
using UnityEngine;

/// Outline and layout discipline for every label this game builds at runtime.
///
/// The shared font material is themed too, but a label created with AddComponent
/// does not inherit a per-label rim, and rule C.10 puts runtime text on the code
/// that made it. So each label gets its own material instance with an outline
/// chosen against its own face colour.
///
/// Wrapping is OFF everywhere and every line break is written by hand as an escape
/// inside the string: TMP decides wrap points per device, so letting it choose
/// means a different number of lines on a different screen. Autosize stays ON with
/// a floor - a line that will not fit shrinks to exactly the floor, so the floor is
/// the size that really ships.
public static class _0xd1591286
{
    public static void ApplyLayout(TMP_Text _0xf6656ca7, float _0x4f8edbc3)
    {
        if (_0xf6656ca7 == null)
        {
            return;
        }

        _0xf6656ca7.textWrappingMode = TextWrappingModes.NoWrap;
        _0xf6656ca7.overflowMode = TextOverflowModes.Overflow;
        _0xf6656ca7.enableAutoSizing = true;
        _0xf6656ca7.fontSizeMin = UiFontFloor;
        _0xf6656ca7.fontSizeMax = Mathf.Max(UiFontFloor, _0x4f8edbc3);
        _0xf6656ca7.fontSize = Mathf.Max(UiFontFloor, _0x4f8edbc3);
    }

    public static void ApplyOutline(TMP_Text _0x61cf8587, Color _0x8b52e486)
    {
        if (_0x61cf8587 == null)
        {
            return;
        }

        Color _0xef7fced2 = _0xa341162f.TextTint(_0x8b52e486);
        _0x61cf8587.color = _0xef7fced2;
        Material _0x8ba1fe63 = _0x61cf8587.fontMaterial;
        if (_0x8ba1fe63 == null)
        {
            return;
        }

        _0x8ba1fe63.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x8ba1fe63.SetColor(ShaderUtilities.ID_OutlineColor, _0xa341162f.VoidDeep);
        _0x8ba1fe63.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.24f);
        _0x8ba1fe63.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }

    /// Readability floor in canvas pixels (ref 1242 x 2688). 30 here is about 26 px
    /// on a 1080 x 2400 device, above the rule C.12 minimum of 24.
    public const float UiFontFloor = 30f;
}