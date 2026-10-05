using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xdababecd : MonoBehaviour
{
    private TMP_Text _0xbe937fbe;
    private Image _0xbc77cae9;
    private void Update()
    {
        this._0x65ff44b6();
    }

    private void _0x65ff44b6()
    {
        if (this._0xbc77cae9.canvasRenderer.GetColor() != this._0xbe937fbe.canvasRenderer.GetColor())
            this._0xbe937fbe.canvasRenderer.SetColor(this._0xbc77cae9.canvasRenderer.GetColor());
    }
}