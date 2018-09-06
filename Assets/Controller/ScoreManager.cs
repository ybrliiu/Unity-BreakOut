using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private int score = 0;
	public Text scoreText;

	public void AddScore(int score) {
		this.score += score;
		this.scoreText.text = this.score.ToString();
	}

}
