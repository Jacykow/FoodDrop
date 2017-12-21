using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FoodSpawner : MonoBehaviour
{
    public GameObject food;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 pos = transform.position + Vector3.up * 2;
            Instantiate(food, pos, Random.rotation);
        }
    }
}