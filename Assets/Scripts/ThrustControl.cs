using UnityEngine;
using System.Collections;

public class ThrustControl : MonoBehaviour {

	public void UpdateThrust(float thrust) {
		transform.localScale = new Vector3(thrust, thrust, thrust);
		if (thrust != 0f) {
			transform.Rotate(new Vector3 (0f, 0f, Random.Range(0f, 360f)));
			Material material = GetComponentInChildren<Renderer>().material;
			Color color = material.color;
			color.a = Random.value;
			material.color = color;
		}
	}
}
