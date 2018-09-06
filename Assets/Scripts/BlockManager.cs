using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

	public GameObject block;
	public int blockNum = 1;

	void Start() {
    	for (float y = 0.0f; y < 1.5f; y += 0.5f) {
        	for (float x = -1.0f; x < 1.0f; x += 0.5f) {
            	Instantiate(block, new Vector3(x * 5, y * 3, 0), Quaternion.identity);
				blockNum++;
        	}
    	}
	}

	void Update() {
		if (blockNum == 0) {
			Debug.Log("CLEAR!!");
		}
	}

	public void DestroyBlock(GameObject block) {
		Destroy(block);
		blockNum--;
	}
	
}
