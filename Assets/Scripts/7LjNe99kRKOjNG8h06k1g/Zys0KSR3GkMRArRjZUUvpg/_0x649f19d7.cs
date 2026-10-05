using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x649f19d7 : MonoBehaviour
{
    private float _0xd120d6f4;
    private float _0x7d41be60 = 0.6f;
    private float _0x2100fb0f = 4;
    private AspectRatioFitter _0x60aac4a3;
    private TMP_Text _0xf5904899;
    private void Update()
    {
        int _0x635017f3 = 1;
        if (this._0x304d116c.Count > 0)
        {
            string _0x58c6a9ec = this._0xf5904899.text;
            foreach (string _0x86fa78fc in this._0x304d116c)
                while (_0x58c6a9ec.Contains(_0x86fa78fc))
                    _0x58c6a9ec = _0x58c6a9ec.Replace(_0x86fa78fc, "");
            _0x635017f3 = _0x58c6a9ec.Length;
        }
        else
        {
            _0x635017f3 = this._0xf5904899.text.Length;
        }

        float _0x0b8490b3 = Mathf.Clamp(this._0xd120d6f4 + this._0x7d41be60 * _0x635017f3, this._0x118d1ec1, this._0x2100fb0f);
        if (!Mathf.Approximately(this._0x60aac4a3.aspectRatio, _0x0b8490b3))
            this._0x60aac4a3.aspectRatio = _0x0b8490b3;
    }

    private float _0x118d1ec1 = 1.5f;
    private List<string> _0x304d116c = new();
}