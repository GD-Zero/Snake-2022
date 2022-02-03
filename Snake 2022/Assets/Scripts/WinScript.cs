using UnityEngine;

public class WinScript : MonoBehaviour
{
    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.tag == "Death")
    //    {
    //        SceneManager.LoadScene(8);
    //    }
    //}

    public GameObject WinPannel, Pause, Left, Right, Score;
    //public GameObject Pause;
    //public GameObject Left;
    //public GameObject Right;
    //public GameObject Score;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Win")
        {
            Time.timeScale = 0;
            WinPannel.SetActive(true);
            Pause.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
            Score.SetActive(false);
        }
    }
}
