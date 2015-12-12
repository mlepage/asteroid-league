using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public float speed;

	void Start() {
	}
	
	void Update() {
		if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.W)) {
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
		} else if (Input.GetKey(KeyCode.Q)) {
			GetComponent<Rigidbody>().AddTorque(Vector3.up * -speed);
		} else if (Input.GetKey(KeyCode.W)) {
			GetComponent<Rigidbody>().AddTorque(Vector3.up * speed);
		}
	}
}
