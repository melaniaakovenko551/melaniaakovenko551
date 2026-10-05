using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xda4490bc : MonoBehaviour
{
    private Canvas _0xe384a164;
    private RectTransform _0x8d5ac723;
    private static Rect _0xe3cac482 = Rect.zero;
    private static Vector2 _0x6021a328 = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0x6021a328.x = Screen.width;
        _0x6021a328.y = Screen.height;
        _0x625104d2.Invoke();
    }

    private void _0x78318a0f()
    {
        if (this._0x8d5ac723 == null)
            return;
        Rect _0x4c1fe44d = Screen.safeArea;
        Vector2 _0xb6bdde23 = _0x4c1fe44d.position;
        Vector2 _0x1af39687 = _0x4c1fe44d.position + _0x4c1fe44d.size;
        _0xb6bdde23.x /= this._0xe384a164.pixelRect.width;
        _0xb6bdde23.y /= this._0xe384a164.pixelRect.height;
        _0x1af39687.x /= this._0xe384a164.pixelRect.width;
        _0x1af39687.y /= this._0xe384a164.pixelRect.height;
        this._0x8d5ac723.anchorMin = _0xb6bdde23;
        this._0x8d5ac723.anchorMax = _0x1af39687;
    }

    private static void SafeAreaChanged()
    {
        _0xe3cac482 = Screen.safeArea;
        for (int _0x2fb86f61 = 0; _0x2fb86f61 < _0xb514aba6.Count; _0x2fb86f61++)
            _0xb514aba6[_0x2fb86f61]._0x78318a0f();
    }

    private void Awake()
    {
        if (!_0xb514aba6.Contains(this))
            _0xb514aba6.Add(this);
        this._0xe384a164 = this.GetComponent<Canvas>();
        this._0xab1d68eb = this.GetComponent<RectTransform>();
        this._0x8d5ac723 = this.transform.Find(_0x256562c1._0x6715d08e(new byte[8] { 16, 34, 37, 38, 2, 49, 38, 34 }, 67)) as RectTransform;
        if (!_0xe8404040)
        {
            _0xe6dc3531 = Screen.orientation;
            _0x6021a328.x = Screen.width;
            _0x6021a328.y = Screen.height;
            _0xe3cac482 = Screen.safeArea;
            _0xe8404040 = true;
        }

        this._0x78318a0f();
    }

    private static UnityEvent _0x625104d2 = new();
    private static bool _0xe8404040;
    private RectTransform _0xab1d68eb;
    private static void OrientationChanged()
    {
        _0xe6dc3531 = Screen.orientation;
        _0x6021a328.x = Screen.width;
        _0x6021a328.y = Screen.height;
        _0x625104d2.Invoke();
    }

    private static ScreenOrientation _0xe6dc3531 = ScreenOrientation.LandscapeLeft;
    private void OnDestroy()
    {
        if (_0xb514aba6 != null && _0xb514aba6.Contains(this))
            _0xb514aba6.Remove(this);
    }

    private void Update()
    {
        if (_0xb514aba6[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xe6dc3531)
            OrientationChanged();
        if (Screen.safeArea != _0xe3cac482)
            SafeAreaChanged();
        if (Screen.width != _0x6021a328.x || Screen.height != _0x6021a328.y)
            ResolutionChanged();
    }

    private static readonly List<_0xda4490bc> _0xb514aba6 = new();
}

internal static class _0x256562c1
{
    internal static string _0x6715d08e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}