using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SnakeMovement : MonoBehaviour
{ 
    public List<GameObject> tailObjects = new List<GameObject>();

    public float z_offset = 0.5f;
    
    public GameObject TailPrefab;

    public UnityEvent OnEatFood;

    [Range(0, 30), SerializeField] public float Speed;

    public void FixedUpdate()
    {
        MoveHead(Speed);
    }

    private void MoveHead(float speed)
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

    void Start()
    {
        tailObjects.Add(gameObject);
    }

    public void AddTail()
    {
        Vector3 newTailPositionition = tailObjects[tailObjects.Count-1].transform.position;
        newTailPositionition.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPositionition, Quaternion.identity) as GameObject);
        OnEatFood.Invoke();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BuffFast"))
        {
            StartCoroutine(fast());
        }        
        else if (other.CompareTag("BuffSlow"))
        {
            StartCoroutine(slow());
        }
        //else if (other.CompareTag("BuffShield"))
        //{
        //    StartCoroutine(shield());
        //}
    }
    public IEnumerator fast()
    {
        OnEatFood.Invoke();
        Time.timeScale = 2f;
        yield return new WaitForSeconds(5f);
        Time.timeScale = 1f;
    }
    public IEnumerator slow()
    {
        OnEatFood.Invoke();
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(3f);
        Time.timeScale = 1f;
    }
    //public IEnumerator shield()
    //{
    //    OnEatFood.Invoke();
    //    gameObject.tag = "Player";
    //    yield return new WaitForSeconds(5f);
    //    gameObject.tag = "SnakeMain";
    //}
}
