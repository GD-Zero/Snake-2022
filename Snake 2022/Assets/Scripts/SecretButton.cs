using UnityEngine;

public class SecretButton : MonoBehaviour
{
    public GameObject Secret;
    public void SecretButtonClick()
    {
        Secret.SetActive(true);
    }
}
