using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xe2e54031 : MonoBehaviour
{
    public GameObject Error;
    public GameObject Content;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xd8d0855e._0xe62aa36f.SCENE_0 && !_0x0f86bc25)
        {
            this._0x4d561ba9();
        }
        else
        {
            this._0xda82211e();
        }
    }

    public GameObject Background;
    public static _0xe2e54031 Instance;
    public void _0xda82211e()
    {
        this._0x68249149();
        bool _0x19a321dd = _0x0f86bc25;
        this._0x1449cde1 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x8c939dda => this.AnimationSlider.value = _0x8c939dda, _0x19a321dd ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x0f86bc25 = !_0x0f86bc25;
    }

    private Sequence _0x1449cde1;
    private void _0x4d561ba9()
    {
        this.AnimationSlider.value = 0.05f;
        _0x0f86bc25 = !_0x0f86bc25;
        this._0x1449cde1 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x8c939dda => this.AnimationSlider.value = _0x8c939dda, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xe283a8a2._0x5695d673?._0x16c4512c();
        });
    }

    public float FirstAnimationTime = 10.0f;
    private static bool _0x0f86bc25 = false;
    public Slider AnimationSlider;
    public float SecondPassSliderValue = 0.5f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe2e54031>();
    }

    public void _0x68249149()
    {
        this._0x1449cde1?.Kill();
        this.AnimationSlider.value = _0x0f86bc25 ? this.SecondPassSliderValue : 0.05f;
    }

    public float DefaultAnimationTime = 0.4f;
    public void _0xdc88c535()
    {
        this._0x1449cde1?.Play();
    }

    public void _0x4cba5af7()
    {
        this._0x1449cde1?.Pause();
    }

    public void _0xa9e40a9d()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x1449cde1?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x0f86bc25 = false;
    }
}