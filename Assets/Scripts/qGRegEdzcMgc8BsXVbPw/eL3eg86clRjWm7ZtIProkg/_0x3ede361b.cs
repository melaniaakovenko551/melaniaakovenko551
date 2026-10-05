using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xd8d0855e;

public class _0x3ede361b : MonoBehaviour
{
    private static _0x22600ad4 _0x7f5ecbde => _0x22600ad4.ALL_SCENES_SETTING_SINGLETONS[0];
    public int _0x65b0d5ee => SceneManager.GetActiveScene().buildIndex;

    public static bool IsAfterLevelComplete;
    public static _0x22600ad4 _0xd0111961 => _0x22600ad4.ALL_SCENES_SETTING_SINGLETONS[Instance._0x65b0d5ee];

    private static _0x22600ad4 GAME_INDEX_SETTINGS(int _0x5df38c1f)
    {
        return _0x22600ad4.ALL_SCENES_SETTING_SINGLETONS[_0x5df38c1f];
    }

    private void Start()
    {
        if (this._0x65b0d5ee != _0xe62aa36f.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xe62aa36f.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xd0111961._0xf83fc287 = false;
            _0xa9368346.Instance._0x7cbe05ff();
            _0x4895092e.Instance._0xe77504a1(_0x1a8d0e5d.TUTORIAL0);
        });
    }

    private void _0x3f85ca32(Transform _0x942404fd)
    {
        Transform[] _0xe88ad562 = _0x942404fd.GetComponentsInChildren<Transform>();
        foreach (Transform _0x2d86a348 in _0xe88ad562)
            if (_0x2d86a348 != null && DOTween.IsTweening(_0x2d86a348))
            {
                if (this._0x35d68e81)
                    DOTween.Play(_0x2d86a348);
                else
                    DOTween.Pause(_0x2d86a348);
            }
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private static void MakeGrid(List<RectTransform> _0x788c350d, AspectRatioFitter _0x81a274a5, float _0xf44f1352, int _0x820e11e7, int _0x62a9240c)
    {
        _0x81a274a5.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x81a274a5.aspectRatio = _0xf44f1352;
        foreach (RectTransform _0x1d5e1999 in _0x788c350d)
        {
            int _0xd8a6d6ad = _0x1d5e1999.transform.GetSiblingIndex();
            _0x1d5e1999.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xd8a6d6ad % _0x820e11e7) * (1f / _0x820e11e7), (_0x62a9240c - (Mathf.FloorToInt((float)_0xd8a6d6ad / _0x820e11e7) % _0x62a9240c + 1f)) * (1f / _0x62a9240c));
            _0x1d5e1999.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xd8a6d6ad % _0x820e11e7 + 1f) * (1f / _0x820e11e7), (_0x62a9240c - Mathf.FloorToInt((float)_0xd8a6d6ad / _0x820e11e7) % _0x62a9240c) * (1f / _0x62a9240c));
            _0x1d5e1999.offsetMin = Vector2.zero;
            _0x1d5e1999.offsetMax = Vector2.zero;
        }
    }

    public void _0x88244216()
    {
        foreach (_0xfbc2e169 _0x3d4009c2 in this.MoneyCountContainers)
            _0x3d4009c2._0x79c61d84();
    }

    public Transform Environment;
    public Transform EnvironmentWithTweensToToggle;
    public static bool IsAfterLevelFailed = false;
    public static _0x3ede361b Instance;
    public void _0xa422ca94()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public Button ShowResetTutorialButton;
    public Canvas MainCanvas;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Button DeleteProgressDataButton;
    private void _0x68b77179()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xe62aa36f.SCENE_0);
    }

    private IEnumerator _0x836907f9(string _0x5cc73a10)
    {
        _0x4895092e.Instance._0xe77504a1(_0x1a8d0e5d.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x2ad92858 = SceneManager.LoadSceneAsync(_0x5cc73a10);
        while (!_0x2ad92858.isDone)
            yield return null;
    }

    public bool _0x35d68e81 { get; private set; }

    private IEnumerator _0x06c71827(int _0xec32e9e0)
    {
        _0x4895092e.Instance._0xe77504a1(_0x1a8d0e5d.SPLASH);
        AsyncOperation _0xbffa1c74 = SceneManager.LoadSceneAsync(_0xec32e9e0);
        while (!_0xbffa1c74.isDone)
            yield return null;
    }

    public void _0xe9bb5dd7()
    {
        _0xd0111961._0xf83fc287 = true;
    }

    public void _0x1f527a59(bool _0xd6581f7d)
    {
        this._0x35d68e81 = _0xd6581f7d;
        this._0xc71ff341(!this._0x35d68e81);
        Physics2D.simulationMode = this._0x35d68e81 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x3f85ca32(this.EnvironmentWithTweensToToggle);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3ede361b>();
        this.RootGameObject = GameObject.FindWithTag(_0xf2f5c1d3._0x3ede8f36(new byte[4] { 45, 16, 16, 11 }, 127));
        if (this._0x65b0d5ee == _0xe62aa36f.SCENE_0)
            this._0x1f527a59(true);
        else
            this._0x1f527a59(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xfbc2e169>(true).ToList();
    }

    private void _0xc71ff341(bool _0x5e3c2b34)
    {
        Rigidbody2D[] _0x01420697 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x20e7b610 in _0x01420697)
            if (_0x5e3c2b34)
                _0x20e7b610.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x20e7b610.constraints = RigidbodyConstraints2D.None;
    }

    public void LoadSceneByIndex(int _0xe0dac490)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x06c71827(_0xe0dac490));
    }

    [HideInInspector]
    public List<_0xfbc2e169> MoneyCountContainers = new();
}

internal static class _0xf2f5c1d3
{
    internal static string _0x3ede8f36(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}