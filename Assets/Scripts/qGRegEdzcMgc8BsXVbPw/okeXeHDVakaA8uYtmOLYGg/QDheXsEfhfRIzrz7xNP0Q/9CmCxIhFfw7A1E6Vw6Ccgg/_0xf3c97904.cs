using UnityEngine;
using UnityEngine.UI;

public class _0xf3c97904 : MonoBehaviour
{
    private bool _0x409e4ad3;
    private Button _0xe1dd9adf;
    private void Awake()
    {
        if (this._0xe1dd9adf == null)
            if (!this.TryGetComponent(out this._0xe1dd9adf))
                this._0xe1dd9adf = this.GetComponentInChildren<Button>();
    }

    private int _0x52a73e7f;
    private void Start()
    {
        if (this._0x409e4ad3)
            this._0xe1dd9adf.onClick.AddListener(() => _0x4895092e.Instance._0x88231dc2());
        else
            this._0xe1dd9adf.onClick.AddListener(() => _0x4895092e.Instance._0xe77504a1(this._0x52a73e7f));
    }
}