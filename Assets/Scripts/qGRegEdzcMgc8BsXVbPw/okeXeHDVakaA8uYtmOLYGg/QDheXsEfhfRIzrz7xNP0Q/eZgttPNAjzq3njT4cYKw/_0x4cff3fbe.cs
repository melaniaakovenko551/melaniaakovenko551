using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x4cff3fbe : MonoBehaviour
{
    public static void HideAllPops()
    {
        _0xa9368346.Instance._0x7cbe05ff();
    }

    public TMP_Text ContentAdditionalText;
    public TMP_Text ContentHeaderText;
    public Ease ease = Ease.OutSine;
    public void _0x3d29b444()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private bool _0x964b3a04 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentMainText;
    private void _0xc600d2fe()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsOnlyYScale;
    public Image ContentImage;
    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    public float scaleDuration = 0.4f;
    private void Start()
    {
    // Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xc600d2fe();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }
}