using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodShootingController : MonoBehaviour {
    
    public GameObject foodProjectile;
    public float force;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject PineApple = Instantiate(
                foodProjectile,
                transform.position,
                Random.rotation
                );
            Vector3 mouseDirection = Camera.main.ScreenPointToRay(Input.mousePosition).direction;
            PineApple.GetComponent<Rigidbody>().velocity = mouseDirection * force;
        }
    }
}
