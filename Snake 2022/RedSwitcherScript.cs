using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSwitcherScript : MonoBehaviour
{
    public GameObject RedSwitcher;
    public GameObject RedSwitcherbase;
    public GameObject RedGate;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "SnakeMain")
        {
            RedSwitcher.SetActive(false);
            RedGate.SetActive(false);
            RedSwitcherbase.SetActive(true);
        }
    }
}
