using UnityEngine;
using UnityEngine.UI;

public class _0x87424749 : MonoBehaviour
{
    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x3ede361b.Instance._0x1f527a59(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}