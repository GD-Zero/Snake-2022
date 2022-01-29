using UnityEngine;
using UnityEngine.UI;

public class FinishGateScript : MonoBehaviour
{

    public GameObject FinishGate;
    public int score;
    public Text scoreText;


    public void Update()
    {
        scoreText.text = score.ToString();
        if (score == 20)
	    {
            FinishGate.SetActive(false);
	    } 
    }
}
