using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject mainPanel;
    [SerializeField]
    private GameObject gamePanel;
    [SerializeField]
    private GameObject settingsPanel;

    public void OpenGamePanel()
    {
        mainPanel.SetActive(false);
        gamePanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void OpenMainPanel()
    {
        mainPanel.SetActive(true);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void OpenSettingsPanel()
    {
        mainPanel.SetActive(false);
        gamePanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
}
