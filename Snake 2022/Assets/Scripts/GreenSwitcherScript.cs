using UnityEngine;

public class GreenSwitcherScript : MonoBehaviour
{
    public GameObject RedSwitcher;
    public GameObject RedSwitcherbase;
    public GameObject RedGate1;
    public GameObject RedGate2;

    public GameObject GreenSwitcher;
    public GameObject GreenSwitcherbase;
    public GameObject GreenGate1;
    public GameObject GreenGate2;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "SnakeMain")
        {
            GreenSwitcher.SetActive(false);
            GreenSwitcherbase.SetActive(true);
            GreenGate1.SetActive(false);
            GreenGate2.SetActive(false);
            
            RedSwitcher.SetActive(true);
            RedSwitcherbase.SetActive(false);
            RedGate1.SetActive(true);
            RedGate2.SetActive(true);
        }
    }
}
