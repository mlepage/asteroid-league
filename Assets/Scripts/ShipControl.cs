using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {

	public KeyCode keyCodeLeft;
	public KeyCode keyCodeRight;
	public KeyCode keyCodeRemove;

	public ThrustControl tcLeft;
	public ThrustControl tcRight;

	public float speed;

	AudioSource audio;
	Rigidbody rigidBody;

	void Start() {
		audio = GetComponent<AudioSource>();
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

		// Update thrust audio
		if (thrustLeft != 0f || thrustRight != 0f) {
			if (!audio.isPlaying) {
				audio.Play();
			}
			audio.volume = (thrustLeft + thrustRight) / 2f;
		} else {
			if (audio.isPlaying) {
				audio.Stop();
			}
		}
	}
}
