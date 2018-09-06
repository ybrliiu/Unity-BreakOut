using UnityEngine;

public class BlockController : MonoBehaviour {

	public GameObject gameManager;
    public GameObject scoreBoard;

	void OnCollisionEnter() {
		Destroy(this.gameObject);
		scoreBoard.GetComponent<ScoreManager>().AddScore(100);
		gameManager.GetComponent<BlockManager>().DestroyBlock(this.gameObject);
	}

}
