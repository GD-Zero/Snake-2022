using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public Text winScoreText;
    public Text deathScoreText;
    public Text pauseScoreText;
    void Start()
    {
        score = 0;    
    }

    void Update()
    {
        scoreText.text = score.ToString();
        winScoreText.text = score.ToString();
        deathScoreText.text = score.ToString();
        pauseScoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider collision)
    {   
        if (collision.tag == "Food")
        {
            score++;
        }
    } 
}
