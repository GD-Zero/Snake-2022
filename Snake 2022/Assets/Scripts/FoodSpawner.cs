using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public float XSize = 20f;
    public float ZSize = 20f;
    public GameObject FoodPrefab;
    public Vector3 CurrentPosition;
    public GameObject CurrentFood;

    void AddNewFood()
    {
        RandomPosition();
        CurrentFood = GameObject.Instantiate(FoodPrefab, CurrentPosition, Quaternion.identity) as GameObject;
    }

    void RandomPosition()
    {
        CurrentPosition = new Vector3(Random.Range(XSize * -1, XSize), 0.5f, Random.Range(ZSize * -1, ZSize));
    }

    public void Update()
    {
        if (!CurrentFood)
        {
            AddNewFood();  
        }
        else
        {
            return;
        }
    }
}