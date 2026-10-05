using UnityEngine;

/// Shows and hides one branch of this game's own interface.
///
/// It deliberately drives only an object this game built. Switching template
/// objects on and off from here would fight the controllers that own them, and a
/// panel the template addresses by index must keep the visibility its own
/// controller gives it.
public sealed class _0xcfce71b1 : MonoBehaviour
{
    [SerializeField]
    private GameObject _content;
    public void _0xef35e1a8()
    {
        if (this._content != null)
        {
            this._content.SetActive(false);
        }
    }

    public void _0x4dfb4884(GameObject _0x6d59c8ad)
    {
        this._content = _0x6d59c8ad;
    }

    public bool _0x62c370fd
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    public void Show()
    {
        if (this._content != null)
        {
            this._content.SetActive(true);
        }
    }
}