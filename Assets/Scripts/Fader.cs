using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fader : MonoBehaviour {

	public float delay = 3f;
	public float time = 2f;

	float elapsed = 0f;

	Text text;

	void Start() {
		text = GetComponent<Text>();
	}

	void Update() {
		elapsed += Time.deltaTime;
		if (elapsed < delay + time) {
			if (delay <= elapsed) {
				// Fade out
				text.color = Color.Lerp(Color.white, Color.clear, (elapsed - delay) / time);
			}
		} else {
			// Done fading
			Destroy(gameObject);
		}
	}
}
