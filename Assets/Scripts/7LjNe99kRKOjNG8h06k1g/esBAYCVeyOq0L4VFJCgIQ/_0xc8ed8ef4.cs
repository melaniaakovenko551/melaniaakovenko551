using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xc8ed8ef4 : MonoBehaviour
{
    private Vector3 _0x5725cf3c { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xd0b1457c;
        Matrix4x4 _0xc2ee2b8b = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xc2cc3580.orthographic)
        {
            float _0xdce3aacb = this._0xc2cc3580.farClipPlane - this._0xc2cc3580.nearClipPlane;
            float _0x6ce5b7f0 = (this._0xc2cc3580.farClipPlane + this._0xc2cc3580.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x6ce5b7f0), new Vector3(this._0xc2cc3580.orthographicSize * 2 * this._0xc2cc3580.aspect, this._0xc2cc3580.orthographicSize * 2, _0xdce3aacb));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xc2cc3580.fieldOfView, this._0xc2cc3580.farClipPlane, this._0xc2cc3580.nearClipPlane, this._0xc2cc3580.aspect);
        }

        Gizmos.matrix = _0xc2ee2b8b;
    }

    private Vector3 _0xa0b72c39 { get; set; }
    private Vector3 _0x62d5c529 { get; set; }
    //public bool executeInUpdate;
    private float _0xeb2fbe3b { get; set; }
    private Vector3 _0xbc932d4a { get; set; }
    private Vector3 _0xda58e0b9 { get; set; }

    private static _0xc8ed8ef4 _0xb21359de;
    private Color _0xd0b1457c = Color.white;
    private _0x16ae544f _0x9df828cf = _0x16ae544f.Portrait;
    private Vector3 _0x624409f6 { get; set; }

    private void _0x981d3092()
    {
        float _0xbad6dc4a, _0x9ca5a540, _0x480309ef, _0xc7d43417;
        if (this._0x9df828cf == _0x16ae544f.Landscape)
            this._0xc2cc3580.orthographicSize = 1f / this._0xc2cc3580.aspect * this._0xe473c2d3 / 2f;
        else
            this._0xc2cc3580.orthographicSize = this._0xe473c2d3 / 2f;
        this._0xcf2f1941 = 2f * this._0xc2cc3580.orthographicSize;
        this._0xeb2fbe3b = this._0xcf2f1941 * this._0xc2cc3580.aspect;
        float _0xe4196f74 = this._0xc2cc3580.transform.position.x;
        float _0x1c5973fe = this._0xc2cc3580.transform.position.y;
        _0xbad6dc4a = _0xe4196f74 - this._0xeb2fbe3b / 2;
        _0x9ca5a540 = _0xe4196f74 + this._0xeb2fbe3b / 2;
        _0x480309ef = _0x1c5973fe + this._0xcf2f1941 / 2;
        _0xc7d43417 = _0x1c5973fe - this._0xcf2f1941 / 2;
        this._0xc92caef9 = new Vector3(_0xbad6dc4a, _0xc7d43417, 0);
        this._0xa0b72c39 = new Vector3(_0xe4196f74, _0xc7d43417, 0);
        this._0x5725cf3c = new Vector3(_0x9ca5a540, _0xc7d43417, 0);
        this._0xda58e0b9 = new Vector3(_0xbad6dc4a, _0x1c5973fe, 0);
        this._0xbc932d4a = new Vector3(_0xe4196f74, _0x1c5973fe, 0);
        this._0x62d5c529 = new Vector3(_0x9ca5a540, _0x1c5973fe, 0);
        this._0x624409f6 = new Vector3(_0xbad6dc4a, _0x480309ef, 0);
        this._0x0f7a1164 = new Vector3(_0xe4196f74, _0x480309ef, 0);
        this._0xdb50e911 = new Vector3(_0x9ca5a540, _0x480309ef, 0);
    }

    private void Awake()
    {
        this._0xc2cc3580 = this.GetComponent<Camera>();
        _0xb21359de = this;
        this._0x981d3092();
    }

    private float _0xe473c2d3 = 1;
    private float _0xcf2f1941 { get; set; }
    private Vector3 _0x0f7a1164 { get; set; }
    private Vector3 _0xdb50e911 { get; set; }
    private Vector3 _0xc92caef9 { get; set; }

    private new Camera _0xc2cc3580;
    public enum _0x16ae544f
    {
        Landscape,
        Portrait
    }
}