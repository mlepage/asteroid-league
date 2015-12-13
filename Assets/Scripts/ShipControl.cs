using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public KeyCode keyCodeLeft;
	public KeyCode keyCodeRight;

	public ThrustControl tcLeft;
	public ThrustControl tcRight;

	public float speed;

	Rigidbody rigidBody;

	void Start() {
		rigidBody = GetComponent<Rigidbody>();
	}

	void Update() {
		float thrustLeft = 0f;
		float thrustRight = 0f;

		if (Input.GetKey(keyCodeLeft) && Input.GetKey(keyCodeRight)) {
			// Go forward and stop turning
			rigidBody.AddRelativeForce(Vector3.forward * speed);
			rigidBody.angularVelocity = Vector3.zero;
			thrustLeft = 1f;
			thrustRight = 1f;
		} else if (Input.GetKey(keyCodeLeft)) {
			// Turn left
			rigidBody.AddTorque(Vector3.up * -speed);
			thrustRight = 1f;
		} else if (Input.GetKey(keyCodeRight)) {
			// Turn right
			rigidBody.AddTorque(Vector3.up * speed);
			thrustLeft = 1f;
		}

		// Update thrust visuals
		tcLeft.UpdateThrust(thrustLeft);
		tcRight.UpdateThrust(thrustRight);
	}
}
