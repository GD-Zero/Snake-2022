using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject effect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<SnakeMovement>().AddTail();
            Destroy(gameObject);
        }
    }
}
