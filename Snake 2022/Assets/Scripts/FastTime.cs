using UnityEngine;
public class FastTime : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMovement>().fast();
            Destroy(gameObject);
        }
    }

}