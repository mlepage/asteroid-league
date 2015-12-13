using UnityEngine;
using System.Collections;

public class PlaySoundOnCollision : MonoBehaviour {

	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}
	
	public void OnCollisionEnter(Collision collision) {
		audio.Play();
	}
}
