using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject PauseB;
    public GameObject Left;
    public GameObject Right;
    public GameObject Score;
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        PauseB.SetActive(false);
        Left.SetActive(false);
        Right.SetActive(false);
        Score.SetActive(false);
    }

    public void Close()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        PauseB.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Score.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void loadClassic1()
    {
        SceneManager.LoadScene("Classic1");
    }

    public void loadArcade1()
    {
        SceneManager.LoadScene("Arcade1");
    }

    public void loadArcade2()
    {
        SceneManager.LoadScene("Arcade2");
    }
    public void loadArcade3()
    {
        SceneManager.LoadScene("Arcade3");
    }
    public void loadArcade4()
    {
        SceneManager.LoadScene("Arcade4");
    }
    public void loadArcade5()
    {
        SceneManager.LoadScene("Arcade5");
    }
    public void loadArcade6()
    {
        SceneManager.LoadScene("Arcade6");
    }
    public void loadArcade7()
    {
        SceneManager.LoadScene("Arcade7");
    }
    public void loadArcade8()
    {
        SceneManager.LoadScene("Arcade8");
    }
    public void loadArcade9()
    {
        SceneManager.LoadScene("Arcade9");
    }
    public void loadArcade10()
    {
        SceneManager.LoadScene("Arcade10");
    }

    public void loadAdventure1()
    {
        SceneManager.LoadScene("Adventure1");
    }

    public void loadAdventure2()
    {
        SceneManager.LoadScene("Adventure2");
    }
    public void loadAdventure3()
    {
        SceneManager.LoadScene("Adventure3");
    }
    public void loadAdventure4()
    {
        SceneManager.LoadScene("Adventure4");
    }
    public void loadAdventure5()
    {
        SceneManager.LoadScene("Adventure5");
    }
}
