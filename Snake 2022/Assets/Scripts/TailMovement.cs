using UnityEngine;

public class TailMovement : MonoBehaviour
{
    //public float Speed;

    [Range(0, 30), SerializeField] public float Speed;

  
    public Vector3 tailTarget;

    public int index;

    public GameObject tailTargetObject;

    public SnakeMovement mainSnake;

    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        Speed = mainSnake.Speed;
        tailTargetObject = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        index = mainSnake.tailObjects.IndexOf(gameObject);
    }

    void Update()
    {
        tailTarget = tailTargetObject.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime * Speed);
    }

    //void OnTriggerEnter()
    //{
    //    if (other.CompareTag("SnakeMain"))
    //    {
    //        if (index > 2)
    //        {
    //            Application.LoadLevel(Application.loadedLevel);
    //        }
    //    }
    //}
}
