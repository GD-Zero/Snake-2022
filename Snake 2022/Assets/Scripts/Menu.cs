using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject ClassicPanel;
    public GameObject ArcadePanel;
    public GameObject AdventurePanel;
    public GameObject InfoPanel;
    public void LoadMainMenu()
    {
        MainPanel.SetActive(true);
        ClassicPanel.SetActive(false);
        ArcadePanel.SetActive(false);
        AdventurePanel.SetActive(false);
        InfoPanel.SetActive(false);
    }

    public void LoadClassicMenu()
    {
        MainPanel.SetActive(false);
        ClassicPanel.SetActive(true);
    }

    public void LoadArcadeMenu()
    {
        MainPanel.SetActive(false);
        ArcadePanel.SetActive(true);
    }

    public void LoadAdventureMenu()
    {
        MainPanel.SetActive(false);
        AdventurePanel.SetActive(true);
    }

    public void LoadInfoMenu()
    {
        MainPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
