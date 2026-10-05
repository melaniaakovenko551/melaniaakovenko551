using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x3247dd9e : MonoBehaviour
{
    private void _0x7c16dcb1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x395d280a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x395d280a, true);
            _0x395d280a.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public float ScaleDuration = 0.4f;
    public void _0xc5e25b67()
    {
        this._0xcf9f7cf1();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private bool _0x08c8e553 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text HeaderText;
    public GameObject Content;
    public TMP_Text MainText;
    public GameObject OuterBackground;
    private void _0xcf9f7cf1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x1cdd245e = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x1cdd245e, true);
            _0x1cdd245e.DOFade(0f, this.ScaleDuration);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x0d379e4d();
    }

    public void _0xfcdebca9()
    {
        this._0xe294785c();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x4895092e.Instance._0x924cf16b(_0x4895092e.Instance.CurrentPanelIndex);
    }

    public bool IsScaledDownOnAwake = true;
    public Ease Ease = Ease.OutSine;
    private void _0xe294785c()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc1c76d46 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc1c76d46, true);
            _0xc1c76d46.DOFade(1f, 0f);
        }
    }

    private void _0x0d379e4d()
    {
        if (this.OuterBackground != null)
        {
            Image _0xd9ce9beb = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xd9ce9beb, true);
            _0xd9ce9beb.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public void Show()
    {
        this._0x7c16dcb1();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x4895092e.Instance._0x924cf16b(_0x4895092e.Instance.CurrentPanelIndex);
            });
        }
    }
}