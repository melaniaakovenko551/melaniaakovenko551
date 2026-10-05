using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x5dbd152f : MonoBehaviour
{
    private Touch? _0x4c9725fb(Bounds _0x21a66066, TouchPhase _0x7c48871f)
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
            return null;
        foreach (Touch _0xd08e5795 in Touch.activeTouches)
            if (_0xd08e5795.phase == _0x7c48871f)
            {
                Vector3 _0x92a59308 = Camera.main.ScreenToWorldPoint(_0xd08e5795.screenPosition);
                Vector3 _0xe5b15f0a = new(_0x92a59308.x, _0x92a59308.y, _0x21a66066.center.z);
                if (_0x21a66066.Contains(_0xe5b15f0a) && this._0xd594d036(_0xd08e5795))
                    return _0xd08e5795;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0xd594d036(Touch? _0x5b676ff6)
    {
        if (!_0x5b676ff6.HasValue)
            return false;
        Vector3 _0x5880bccc = Camera.main.ScreenToWorldPoint(_0x5b676ff6.Value.screenPosition);
        Vector3 _0xb6a428ad = _0x5880bccc;
        _0xb6a428ad.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xb6a428ad))
            return true;
        _0x5b676ff6 = null;
        return false;
    }

    private bool _0x428fbe17(Touch? _0xe5263200, Bounds _0xbfd0ac85, TouchPhase _0xf76ae0c5)
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
        {
            _0xe5263200 = null;
            return false;
        }

        if (_0xe5263200 != null)
            if (_0xe5263200.Value.phase == _0xf76ae0c5)
            {
                Vector3 _0x3e30a637 = Camera.main.ScreenToWorldPoint(_0xe5263200.Value.screenPosition);
                Vector3 _0xcf51cd2b = new(_0x3e30a637.x, _0x3e30a637.y, _0xbfd0ac85.center.z);
                if (_0xbfd0ac85.Contains(_0xcf51cd2b) && this._0xd594d036(_0xe5263200.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x336486cc()
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
            return null;
        foreach (Touch _0x1a6b532b in Touch.activeTouches)
            if (_0x1a6b532b.ended)
                if (this._0xd594d036(_0x1a6b532b))
                    return _0x1a6b532b;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x0b567382 = this.gameObject.GetComponent<_0x5dbd152f>();
    }

    private void _0xb2b5c721(Touch? _0x4e9d1046)
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
        {
            _0x4e9d1046 = null;
            return;
        }

        int _0x36cf990f = _0x4e9d1046.Value.touchId;
        _0x4e9d1046 = Touch.activeTouches.FirstOrDefault(_0x51d4002b => _0x51d4002b.touchId == _0x36cf990f);
        if (!this._0xd594d036(_0x4e9d1046.Value))
            _0x4e9d1046 = null;
    }

    private Touch? _0xdae294c7(Bounds _0x542c6cf5)
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
            return null;
        foreach (Touch _0x2f6d0b6d in Touch.activeTouches)
            if (_0x2f6d0b6d.ended)
            {
                Vector3 _0x654e5a39 = Camera.main.ScreenToWorldPoint(_0x2f6d0b6d.screenPosition);
                Vector3 _0x9795405f = new(_0x654e5a39.x, _0x654e5a39.y, _0x542c6cf5.center.z);
                if (_0x542c6cf5.Contains(_0x9795405f) && this._0xd594d036(_0x2f6d0b6d))
                    return _0x2f6d0b6d;
            }

        return null;
    }

    private Touch? _0xb03fd284()
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
            return null;
        foreach (Touch _0xd2348909 in Touch.activeTouches)
            if (!_0xd2348909.ended)
                if (this._0xd594d036(_0xd2348909))
                    return _0xd2348909;
        return null;
    }

    private Touch? _0xfeafaebb(Bounds _0xf0802c4e)
    {
        if (!_0x3ede361b.Instance._0x35d68e81)
            return null;
        foreach (Touch _0xe86e98b5 in Touch.activeTouches)
            if (!_0xe86e98b5.ended)
            {
                Vector3 _0xa3e9e4ab = Camera.main.ScreenToWorldPoint(_0xe86e98b5.screenPosition);
                Vector3 _0x318ea1d2 = new(_0xa3e9e4ab.x, _0xa3e9e4ab.y, _0xf0802c4e.center.z);
                if (_0xf0802c4e.Contains(_0x318ea1d2) && this._0xd594d036(_0xe86e98b5))
                    return _0xe86e98b5;
            }

        return null;
    }

    private static _0x5dbd152f _0x0b567382;
}