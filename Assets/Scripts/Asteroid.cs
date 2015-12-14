using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	GameController game;
	AudioSource audio;

	void Start() {
		game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		audio = GetComponent<AudioSource>();
	}

	public void OnCollisionEnter(Collision collision) {
		GameObject other = collision.gameObject;
		if (other.CompareTag("Ship")) {
			game.PlayRandomSound(audio, game.kickClips);
		} else if (other.CompareTag("Wall")) {
			game.PlayRandomSound(audio, game.bounceClips);
		}
	}
}
