using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float xSpeed;
	public float ySpeed;
	public float zSpeed;

	void Update() {
		transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
	}
}
