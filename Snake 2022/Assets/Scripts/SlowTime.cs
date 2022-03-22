using UnityEngine;
public class SlowTime : MonoBehaviour 
{
    public GameObject slowEffect;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            Instantiate(slowEffect, transform.position, Quaternion.identity);
            other.GetComponent<SnakeMovement>().slow();
            Destroy(gameObject);
        }
    }
}