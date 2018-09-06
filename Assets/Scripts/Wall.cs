using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.name == "Ball") {
			GameObject ball     = collision.gameObject;
			Rigidbody rigidbody = ball.GetComponent<Rigidbody>();
			Vector3 velocity = rigidbody.velocity;
			var newVelocity = new Vector3(
				velocity.x * 2.5f,
				velocity.y * 2.0f,
				0.0f
			).normalized * 10.0f;
			Debug.Log(rigidbody.velocity);
			Debug.Log(newVelocity);
			rigidbody.velocity = newVelocity;
		}
	}

}
