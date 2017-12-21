using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FoodDestroyer : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }
    }
}