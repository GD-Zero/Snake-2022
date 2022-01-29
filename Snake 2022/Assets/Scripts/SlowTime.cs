using UnityEngine;
public class SlowTime : MonoBehaviour 
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMovement>().slow();
            Destroy(gameObject);
        }
    }
}