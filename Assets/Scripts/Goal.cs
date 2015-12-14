using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Goal : MonoBehaviour {

	public Text scoreText;
	public GameObject asteroid;

	void OnTriggerEnter(Collider other) {
		// Increase score
		int score = 0;
		int.TryParse(scoreText.text, out score);
		++score;
		scoreText.text = score.ToString();

		// Reset asteroid
		Rigidbody rigidBody = asteroid.GetComponent<Rigidbody>();
		rigidBody.velocity = Vector3.zero;
		rigidBody.angularVelocity = Vector3.zero;
		asteroid.transform.position = Vector3.zero;

		// Play goal sound
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayOneShot(audio.clip);

		// Play crowd cheer sound
		//audio = GameObject.Find("Crowd").GetComponent<AudioSource>();
		//audio.PlayOneShot(audio.clip);
	}
}
