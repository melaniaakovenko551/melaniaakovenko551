using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x5ff4baa3 : MonoBehaviour
{
    private static readonly List<_0x5ff4baa3> _0xbdfdf50f = new();
    private static void ApplySafeAreaToAll()
    {
        for (int _0xccfbd60c = 0; _0xccfbd60c < _0xbdfdf50f.Count; _0xccfbd60c++)
            _0xbdfdf50f[_0xccfbd60c]._0x003ed773();
    }

    private CanvasScaler _0x374e3038;
    private static void OrientationChanged()
    {
        _0xf6cad4d2 = Screen.orientation;
        _0x0ab898ff.x = Screen.width;
        _0x0ab898ff.y = Screen.height;
        _0x3719cdcf = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x78099cd9.Invoke();
    }

    private static Vector2 _0x0ab898ff = Vector2.zero;
    private static Rect _0x3719cdcf = Rect.zero;
    private void Update()
    {
        if (_0xbdfdf50f.Count == 0 || _0xbdfdf50f[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xf6cad4d2)
            OrientationChanged();
        if (Screen.safeArea != _0x3719cdcf)
            SafeAreaChanged();
        if (Screen.width != _0x0ab898ff.x || Screen.height != _0x0ab898ff.y)
            ResolutionChanged();
    }

    private Vector2 _0x6cb22b92;
    private static void SafeAreaChanged()
    {
        _0x3719cdcf = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private RectTransform _0x0bbe8cfe;
    private Canvas _0x600d031a;
    private void OnDestroy()
    {
        if (_0xbdfdf50f != null && _0xbdfdf50f.Contains(this))
            _0xbdfdf50f.Remove(this);
    }

    private void _0x003ed773()
    {
        if (this._0x0bbe8cfe == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xa3288711 = Screen.safeArea;
        Vector2 _0xa6e3e424 = _0xa3288711.position;
        Vector2 _0x2115f878 = _0xa3288711.position + _0xa3288711.size;
        _0xa6e3e424.x /= screenWidth;
        _0xa6e3e424.y /= screenHeight;
        _0x2115f878.x /= screenWidth;
        _0x2115f878.y /= screenHeight;
        this._0x0bbe8cfe.anchorMin = _0xa6e3e424;
        this._0x0bbe8cfe.anchorMax = _0x2115f878;
        this._0x0bbe8cfe.offsetMin = Vector2.zero;
        this._0x0bbe8cfe.offsetMax = Vector2.zero;
        if (this._0x374e3038 == null)
            return;
        Vector2 _0x9201eca4 = _0x2115f878 - _0xa6e3e424;
        float _0x87e5f853 = 2f - _0x9201eca4.x;
        float _0x32774633 = 2f - _0x9201eca4.y;
        this._0x374e3038.referenceResolution = this._0x6cb22b92 * new Vector2(_0x87e5f853, _0x32774633);
    }

    private static bool _0x768a681d;
    private void Awake()
    {
        if (!_0xbdfdf50f.Contains(this))
            _0xbdfdf50f.Add(this);
        this._0x600d031a = this.GetComponent<Canvas>();
        this._0x374e3038 = this.GetComponent<CanvasScaler>();
        if (this._0x374e3038 != null)
            this._0x6cb22b92 = this._0x374e3038.referenceResolution;
        this._0x03813c98 = this.GetComponent<RectTransform>();
        this._0x0bbe8cfe = this.transform.Find(_0x123a9619._0xd1e890dc(new byte[8] { 192, 242, 245, 246, 210, 225, 246, 242 }, 147)) as RectTransform;
        if (!_0x768a681d)
        {
            _0xf6cad4d2 = Screen.orientation;
            _0x0ab898ff.x = Screen.width;
            _0x0ab898ff.y = Screen.height;
            _0x3719cdcf = Screen.safeArea;
            _0x768a681d = true;
        }

        this._0x003ed773();
    }

    private static UnityEvent _0x78099cd9 = new();
    private RectTransform _0x03813c98;
    private static ScreenOrientation _0xf6cad4d2 = ScreenOrientation.LandscapeLeft;
    private static void ResolutionChanged()
    {
        _0x0ab898ff.x = Screen.width;
        _0x0ab898ff.y = Screen.height;
        _0x3719cdcf = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x78099cd9.Invoke();
    }

    private void Start()
    {
    }
}

internal static class _0x123a9619
{
    internal static string _0xd1e890dc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}