using UnityEngine;

public class RedSwitcherScript : MonoBehaviour
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
            RedSwitcher.SetActive(false);
            RedSwitcherbase.SetActive(true);
            RedGate1.SetActive(false);
            RedGate2.SetActive(false);

            GreenSwitcher.SetActive(true);
            GreenSwitcherbase.SetActive(false);
            GreenGate1.SetActive(true);
            GreenGate2.SetActive(true);
        }
    }
}
