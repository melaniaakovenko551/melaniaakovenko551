using UnityEngine;
using UnityEngine.EventSystems;

/// Forwards a tap on the arena surface to the director.
///
/// The surface and the director live on different objects - the catcher has to be
/// the FIRST child of the interface host so later-built buttons win the raycast,
/// while the director is the scene root - so the pointer interface is implemented
/// here and relayed, rather than putting an Image on the root.
public sealed class _0xb5e3c385 : MonoBehaviour, IPointerClickHandler
{
    public void _0xcdef5066(_0x0fd90b95 _0x7d962e5d)
    {
        this._0xe07bac83 = _0x7d962e5d;
    }

    public void OnPointerClick(PointerEventData _0x6def7777)
    {
        if (this._0xe07bac83 != null)
        {
            this._0xe07bac83.OnPointerClick(_0x6def7777);
        }
    }

    private _0x0fd90b95 _0xe07bac83;
}