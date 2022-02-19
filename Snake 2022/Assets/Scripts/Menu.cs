using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainPanel, ClassicPanel, ArcadePanel, AdventurePanel, InfoPanel, AchievementsPanel, SettingsPanel, HelpPanel, SoundOn, SoundOff;
    public int mainScore, receivedScore;
    public Text mScoreText;
    private bool isMute;

    public void Start()
    {
        mainScore = PlayerPrefs.GetInt("MainScore");
        receivedScore = PlayerPrefs.GetInt("Score");
        mainScore += receivedScore;
        PlayerPrefs.SetInt("MainScore", mainScore);
        mScoreText.text = mainScore.ToString();
        receivedScore = 0;
        PlayerPrefs.SetInt("Score", receivedScore);
        isMute = PlayerPrefs.GetInt("Mute") == 1;
        AudioListener.pause = isMute;
    }
    public void LoadMainMenu()
    {
        MainPanel.SetActive(true);
        ClassicPanel.SetActive(false);
        ArcadePanel.SetActive(false);
        AdventurePanel.SetActive(false);
        InfoPanel.SetActive(false);
        AchievementsPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        HelpPanel.SetActive(false);
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
    public void LoadAchievementsPanel()
    {
        MainPanel.SetActive(false);
        AchievementsPanel.SetActive(true);
    }
    public void LoadInfoPanel()
    {
        MainPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }
    public void LoadSettingsPanel()
    {
        MainPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }
    public void LoadHelpPanel()
    {
        MainPanel.SetActive(false);
        HelpPanel.SetActive(true);
    }
    public void SoundPlay()
    {
        isMute = !isMute;
        AudioListener.pause = isMute;
        PlayerPrefs.SetInt("Mute", isMute ? 1 : 0);
        SoundOff.SetActive(true);
        SoundOn.SetActive(false);
    }
    public void SoundPause()
    {
        isMute = !isMute;
        AudioListener.pause = isMute;
        PlayerPrefs.SetInt("Mute", isMute ? 1 : 0);
        SoundOff.SetActive(false);
        SoundOn.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
