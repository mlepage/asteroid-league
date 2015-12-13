using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {

	public float min = 0f;
	public float max = 1f;

	Material material;

	void Start() {
		material = GetComponentInChildren<Renderer>().material;
	}

	void Update() {
		Color color = material.color;
		color.a = Random.Range(min, max);
		material.color = color;
	}
}
