using UnityEngine;

public class DeathScript : MonoBehaviour
{
    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.tag == "Death")
    //    {
    //        SceneManager.LoadScene(8);
    //    }
    //}

    public GameObject DeathPanel, Pause, Left, Right, Score, deadSound;
    //public GameObject Pause;
    //public GameObject Left;
    //public GameObject Right;
    //public GameObject Score;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Death")
        {
            Instantiate(deadSound, transform.position, Quaternion.identity);
            Time.timeScale = 0;
            DeathPanel.SetActive(true);
            Pause.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
            Score.SetActive(false);
        }
    }
}
