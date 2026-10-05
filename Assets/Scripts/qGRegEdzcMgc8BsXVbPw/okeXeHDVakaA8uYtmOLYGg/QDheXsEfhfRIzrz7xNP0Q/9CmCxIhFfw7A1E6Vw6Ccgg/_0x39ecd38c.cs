using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x39ecd38c : MonoBehaviour
{
    public int LoadSceneId;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x3ede361b.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x3ede361b.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
}