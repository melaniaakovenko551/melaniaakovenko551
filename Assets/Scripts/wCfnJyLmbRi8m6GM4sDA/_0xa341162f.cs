using UnityEngine;

/// The whole colour vocabulary of this game, declared once.
///
/// The font material carries ONE outline colour for the entire app (VoidDeep), so
/// every colour used as TEXT has to be light enough to clear it. The contrast
/// figures against VoidDeep are: Cream 15.9:1, Gold 11.4:1, Teal 8.1:1,
/// CrimsonLit 7.3:1 - all above the 7:1 target. Crimson itself sits at 4.5:1 and
/// is therefore a SPRITE colour only; Void / VoidLift / VoidDeep are surfaces and
/// are never text. TextTint() is the guard that keeps that true at the one place
/// where it could go wrong.
public static class _0xa341162f
{
    public static readonly Color Teal = Hex(0x32BBAA);
    public static readonly Color Void = Hex(0x17131E);
    /// Last line of defence for rule C.14. A surface colour handed to a text
    /// argument - the classic swap of the fill and tint parameters - would ship
    /// near-black glyphs on a dark card, which is how a CTA ends up unreadable.
    /// Anything too dark to clear the shared outline is lifted to Cream.
    public static Color TextTint(Color _0x3d2e0a1b)
    {
        float _0xaeeb7eda = (0.299f * _0x3d2e0a1b.r) + (0.587f * _0x3d2e0a1b.g) + (0.114f * _0x3d2e0a1b.b);
        return _0xaeeb7eda < 0.45f ? Cream : _0x3d2e0a1b;
    }

    public static readonly Color VoidLift = Hex(0x241B31);
    public static Color WithAlpha(Color _0x1e5b6d6d, float _0x9a43eda5)
    {
        return new Color(_0x1e5b6d6d.r, _0x1e5b6d6d.g, _0x1e5b6d6d.b, _0x9a43eda5);
    }

    public static readonly Color CrimsonLit = Hex(0xF2708F);
    public static readonly Color Crimson = Hex(0xDE3B63);
    public static readonly Color VoidDeep = Hex(0x0E0B14);
    public static readonly Color Cream = Hex(0xF5EADC);
    public static readonly Color Gold = Hex(0xF0C04C);
    public static readonly Color Violet = Hex(0x813EB6);
    public static readonly Color VioletLit = Hex(0x9A52D2);
    public static Color Hex(int _0xa58d210e)
    {
        float _0x24921f90 = ((_0xa58d210e >> 16) & 0xFF) / 255f;
        float _0x9ef27954 = ((_0xa58d210e >> 8) & 0xFF) / 255f;
        float _0xb04e82a1 = (_0xa58d210e & 0xFF) / 255f;
        return new Color(_0x24921f90, _0x9ef27954, _0xb04e82a1, 1f);
    }
}