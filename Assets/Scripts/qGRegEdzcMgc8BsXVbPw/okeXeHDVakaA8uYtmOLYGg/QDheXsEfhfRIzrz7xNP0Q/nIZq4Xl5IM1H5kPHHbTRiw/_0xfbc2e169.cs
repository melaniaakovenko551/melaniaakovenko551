using TMPro;
using UnityEngine;
using static _0xd8d0855e;

public class _0xfbc2e169 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x1b4d3a6f;
            if (this.gameObject.TryGetComponent(out _0x1b4d3a6f))
                this.MoneyCountText = _0x1b4d3a6f;
        }

        this._0x79c61d84();
    }

    public TMP_Text MoneyCountText;
    public void _0x79c61d84()
    {
        this.MoneyCountText.text = _0xd165425b._0xd82d10c8.ToString();
    }
}