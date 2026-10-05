using TMPro;
using UnityEngine;

/// Everything this game does TO the scene template: reaching panel bodies by their
/// SETTINGS index, clearing the ones it rebuilds, and blanking the filler copy on
/// pages it never opens.
///
/// Panels are addressed by index only. Object names do not survive the release
/// build's symbol renaming, and the controllers index their pools, so the index is
/// the one durable handle. GetPanel(int) is private on this template, so the body
/// is reached through the public Panels list instead.
public static class _0x2eb0f825
{
    /// Switches off whatever the template put into a panel body so this game can
    /// build its own.
    ///
    /// Two branches are always spared. A branch holding a Pop must survive, because
    /// pops are addressed by index and this body is not their owner. And `keep` is
    /// refused if it IS the body or an ancestor of it - a template label can be a
    /// direct child of Content, and walking up from it to "its panel" would switch
    /// off the whole screen.
    public static void ClearPanelBody(int _0x9bf776cb, Transform _0x65d08f93)
    {
        Transform _0x222d8bee = PanelBody(_0x9bf776cb);
        if (_0x222d8bee == null)
        {
            return;
        }

        if (_0x65d08f93 != null && (_0x65d08f93 == _0x222d8bee || _0x222d8bee.IsChildOf(_0x65d08f93)))
        {
            return;
        }

        for (int _0xcd22c918 = _0x222d8bee.childCount - 1; _0xcd22c918 >= 0; _0xcd22c918--)
        {
            Transform _0x33e6f940 = _0x222d8bee.GetChild(_0xcd22c918);
            if (_0x33e6f940 == null)
            {
                continue;
            }

            if (_0x33e6f940.GetComponentInChildren<_0x4cff3fbe>(true) != null)
            {
                continue;
            }

            if (_0x65d08f93 != null && (_0x33e6f940 == _0x65d08f93 || _0x65d08f93.IsChildOf(_0x33e6f940)))
            {
                continue;
            }

            _0x33e6f940.gameObject.SetActive(false);
        }
    }

    /// Every tutorial page the template declares. This game rewrites the first two
    /// and shows them from its own menu button; the rest are never opened, but
    /// their shipped filler copy must not reach the build either (rule C.15).
    private static readonly int[] _0x0fd75ef7 =
    {
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL0,
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL1,
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL2,
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL3,
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL4,
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL5,
        _0xd8d0855e._0x1a8d0e5d.TUTORIAL6,
    };
    /// Empties the filler strings from the pages this game does not dress itself.
    /// The pages stay in the pool: the controller addresses panels by index, so a
    /// removed page would shift every index after it.
    public static void BlankUnusedPages(int _0xd28e9911, int _0xd0a3a027)
    {
        for (int _0xdfa55137 = 0; _0xdfa55137 < _0x0fd75ef7.Length; _0xdfa55137++)
        {
            int _0x8bc5de4f = _0x0fd75ef7[_0xdfa55137];
            if (_0x8bc5de4f == _0xd28e9911 || _0x8bc5de4f == _0xd0a3a027)
            {
                continue;
            }

            Transform _0xf31c8471 = PanelBody(_0x8bc5de4f);
            if (_0xf31c8471 == null)
            {
                continue;
            }

            TMP_Text[] _0xe1224597 = _0xf31c8471.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xc5a580a7 = 0; _0xc5a580a7 < _0xe1224597.Length; _0xc5a580a7++)
            {
                if (_0xe1224597[_0xc5a580a7] != null)
                {
                    _0xe1224597[_0xc5a580a7].text = string.Empty;
                }
            }
        }
    }

    public static Transform PanelBody(int _0xd1f65686)
    {
        _0x4895092e _0x158784d9 = _0x4895092e.Instance;
        if (_0x158784d9 == null || _0x158784d9.Panels == null)
        {
            return null;
        }

        if (_0xd1f65686 < 0 || _0xd1f65686 >= _0x158784d9.Panels.Count)
        {
            return null;
        }

        _0x3247dd9e _0xe43fa8c6 = _0x158784d9.Panels[_0xd1f65686];
        if (_0xe43fa8c6 == null || _0xe43fa8c6.Content == null)
        {
            return null;
        }

        return _0xe43fa8c6.Content.transform;
    }
}