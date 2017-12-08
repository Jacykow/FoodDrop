using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenShooter : MonoBehaviour {

	public GameObject meat;
	public float force;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 position = transform.position;
			GameObject kurczak = Instantiate (meat, position, Random.rotation);
			Ray ray = gameObject.GetComponent<Camera> ().ScreenPointToRay (Input.mousePosition);
			kurczak.GetComponent<Rigidbody> ().velocity = ray.direction * force;
		}
	}
}
