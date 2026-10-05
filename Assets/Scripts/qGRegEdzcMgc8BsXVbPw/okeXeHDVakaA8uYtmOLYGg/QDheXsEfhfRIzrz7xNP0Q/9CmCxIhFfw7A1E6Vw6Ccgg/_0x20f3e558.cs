using UnityEngine;
using UnityEngine.UI;

public class _0x20f3e558 : MonoBehaviour
{
    public bool IsShowLastPop;
    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xa9368346.Instance._0x964f2bf3();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xa9368346.Instance._0x7cbe05ff());
        else
            this.Button.onClick.AddListener(() => _0xa9368346.Instance._0x4d67d626(this.PopToShowIndex));
    }

    public Button Button;
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}