using UnityEngine;
using UnityEngine.UI;

public class FinishScore : MonoBehaviour
{
    private int score;
    public int highscore;
    public Text scoreText;
    public GameObject FinishGate;

    void Start()
    {
        score = 0;    
    }

    void FixedUpdate()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Food")
        {
            score++;
        }
    } 
    void Update()
    {
        if (score == highscore)
        {
            FinishGate.SetActive(false);
        }
    }
}
