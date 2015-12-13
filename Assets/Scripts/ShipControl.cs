using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public ThrustControl tcLeft;
	public ThrustControl tcRight;

	public float speed;

	void Update() {
		float thrustLeft = 0f;
		float thrustRight = 0f;

		if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.W)) {
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
			thrustLeft = 1f;
			thrustRight = 1f;
		} else if (Input.GetKey(KeyCode.Q)) {
			GetComponent<Rigidbody>().AddTorque(Vector3.up * -speed);
			thrustRight = 1f;
		} else if (Input.GetKey(KeyCode.W)) {
			GetComponent<Rigidbody>().AddTorque(Vector3.up * speed);
			thrustLeft = 1f;
		}

		tcLeft.UpdateThrust(thrustLeft);
		tcRight.UpdateThrust(thrustRight);
	}
}
