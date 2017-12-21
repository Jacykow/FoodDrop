using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraRotationScript : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}