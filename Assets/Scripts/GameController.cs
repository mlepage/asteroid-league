using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject ship1;
	public GameObject ship2;
	public GameObject ship3;
	public GameObject ship4;

	public AudioClip[] kickClips;
	public AudioClip[] bounceClips;

	void Update() {
		// Shift + 1 (or 2 to 4) toggles whether each ship is active
		if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) {
			if (Input.GetKeyDown(KeyCode.Alpha1)) {
				ship1.SetActive(!ship1.activeSelf);
			}
			if (Input.GetKeyDown(KeyCode.Alpha2)) {
				ship2.SetActive(!ship2.activeSelf);
			}
			if (Input.GetKeyDown(KeyCode.Alpha3)) {
				ship3.SetActive(!ship3.activeSelf);
			}
			if (Input.GetKeyDown(KeyCode.Alpha4)) {
				ship4.SetActive(!ship4.activeSelf);
			}
		}
	}

	public void PlayRandomSound(AudioSource audio, AudioClip[] clips) {
		audio.PlayOneShot(clips[Random.Range(0, clips.Length)]);
	}
}
