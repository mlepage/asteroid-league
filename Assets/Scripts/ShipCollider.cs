using UnityEngine;
using System.Collections;

public class ShipCollider : MonoBehaviour {

	GameController game;
	AudioSource audio;

	void Start() {
		game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

		// The issue here is that there's already an audio source on the ship for thrust sound
		// Need to sort this out but running out of time
		audio = gameObject.AddComponent<AudioSource>();
	}

	public void OnCollisionEnter(Collision collision) {
		Debug.Log ("ship collision");
		GameObject other = collision.gameObject;
		if (other.CompareTag("Ship")) {
			// In ship to ship collisions, only one should play the sound
			float x1 = transform.position.x;
			float z1 = transform.position.z;
			float x2 = other.transform.position.x;
			float z2 = other.transform.position.z;
			if (x1<x2 || x1==x2 && z1<z2) {
				game.PlayRandomSound(audio, game.bounceClips);
			}
		} else if (other.CompareTag("Wall")) {
			game.PlayRandomSound(audio, game.bounceClips);
		}
	}
}
