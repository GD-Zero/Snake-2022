using UnityEngine;
public class FastTime : MonoBehaviour
{
    public GameObject fastEffect;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            Instantiate(fastEffect, transform.position, Quaternion.identity);
            other.GetComponent<SnakeMovement>().fast();
            Destroy(gameObject);
        }
    }

}