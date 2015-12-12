using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public float speed;

	void Start() {
	}
	
	void Update() {
		if (Input.GetKeyDown(KeyCode.Q)) {
			GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
		}
	}
}
