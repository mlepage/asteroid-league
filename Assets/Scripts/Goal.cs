using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Goal : MonoBehaviour {

	public Text scoreText;

	void OnTriggerEnter(Collider other) {
		int score = 0;
		int.TryParse(scoreText.text, out score);
		++score;
		scoreText.text = score.ToString();
	}
}
