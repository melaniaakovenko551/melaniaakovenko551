using UnityEngine;
using UnityEngine.UI;

public class _0x587f0011 : MonoBehaviour
{
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x4895092e.Instance._0xe77504a1(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x3ede361b.Instance._0xe9bb5dd7());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x4895092e.Instance._0xe77504a1(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x4895092e.Instance._0xe77504a1(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x3ede361b.Instance._0xe9bb5dd7());
        }
    }

    public Button TutorialEndButton;
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
}