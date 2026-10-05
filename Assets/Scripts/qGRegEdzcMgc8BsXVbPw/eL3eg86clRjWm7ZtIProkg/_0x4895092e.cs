using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xd8d0855e;

public class _0x4895092e : MonoBehaviour
{
    private void _0x77cffcb7(int _0xcd13c977)
    {
        if (_0xcd13c977 == _0x1a8d0e5d.SPLASH)
            _0xe2e54031.Instance._0x68249149();
        if (_0x3ede361b.Instance._0x65b0d5ee == _0xe62aa36f.SCENE_0)
        {
        }
    }

    private _0x3247dd9e _0x9d9551a0(int _0x749b5b74)
    {
        return this.Panels[_0x749b5b74];
    }

    private void _0xe047c230()
    {
        this._0x8af6fc82(_0x1a8d0e5d.SPLASH);
        if (_0x3ede361b.Instance._0x65b0d5ee == _0xe62aa36f.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xe2e54031.Instance.DefaultAnimationTime);
        }
    }

    public List<_0x3247dd9e> Panels;
    private void _0x8af6fc82(int _0x549316f1)
    {
        this._0x04e51d93(_0x549316f1);
        this._0x77cffcb7(_0x549316f1);
        this.CurrentPanelIndex = _0x549316f1;
        this.Panels[_0x549316f1]._0xfcdebca9();
    }

    public bool IsShowSplashOnStart = true;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0xe77504a1(int _0xeeb79e5d)
    {
        this._0x04e51d93(_0xeeb79e5d);
        this._0x77cffcb7(_0xeeb79e5d);
        this.CurrentPanelIndex = _0xeeb79e5d;
        this.Panels[_0xeeb79e5d].Show();
    }

    private void Start()
    {
        this._0xe047c230();
    }

    public static _0x4895092e Instance;
    public int CurrentPanelIndex;
    private void _0x04e51d93(int _0xe32a8251)
    {
        this.LastPanelIndexes.Add(_0xe32a8251);
        this.CurrentPanelIndex = _0xe32a8251;
        for (int _0x86c2096d = 0; _0x86c2096d < this.Panels.Count; _0x86c2096d++)
            if (_0x86c2096d != _0xe32a8251 && this.Panels[_0x86c2096d] != null)
                this.Panels[_0x86c2096d]._0xc5e25b67();
    }

    public float StaticBlurMaterialInitialValue;
    private void SwitchSplash()
    {
        if (_0x2376204a.Instance.IsTutorialEnabled && !_0x3ede361b._0xd0111961._0xf83fc287)
            this._0xe77504a1(_0x1a8d0e5d.TUTORIAL0);
        else
            this._0xe77504a1(_0x1a8d0e5d.DEFAULT);
    }

    public float ScaleDuration = 0.4f;
    private void _0xb2922c9c(int _0x373208e7)
    {
        this.LastPanelIndexes.Add(_0x373208e7);
        this.CurrentPanelIndex = _0x373208e7;
        for (int _0xa1c8f4f5 = 0; _0xa1c8f4f5 < this.Panels.Count; _0xa1c8f4f5++)
            if (_0xa1c8f4f5 != _0x373208e7 && this.Panels[_0xa1c8f4f5] != null)
                this.Panels[_0xa1c8f4f5]._0xc5e25b67();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x4895092e>();
    }

    public void _0x88231dc2()
    {
        this.LastPanelIndexes.RemoveAll(_0x3a750824 => _0x3a750824 == this.CurrentPanelIndex);
        int _0xb8404a8a = this.LastPanelIndexes.Last();
        this._0x77cffcb7(_0xb8404a8a);
        this._0xb2922c9c(_0xb8404a8a);
        this.CurrentPanelIndex = _0xb8404a8a;
        this.Panels[_0xb8404a8a].Show();
    }

    public void _0x924cf16b(int _0xa175919a)
    {
        if (_0xa175919a == _0x1a8d0e5d.SPLASH && _0x3ede361b.Instance._0x65b0d5ee != _0xe62aa36f.SCENE_0)
            _0xe2e54031.Instance._0xda82211e();
        if (_0x3ede361b.Instance._0x65b0d5ee != _0xe62aa36f.SCENE_0)
        {
            if (_0xa175919a == _0x1a8d0e5d.SPLASH || _0xa175919a == _0x1a8d0e5d.TUTORIAL0)
                _0x3ede361b.Instance._0x1f527a59(false);
            else if (_0xa175919a == _0x1a8d0e5d.DEFAULT)
                _0x3ede361b.Instance._0x1f527a59(true);
        }
    }
}