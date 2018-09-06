using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour {

	public GameObject ball;
			
	private float speed = 10;
	private bool doesBallOnTop = true;
	
	void Update() {
		if ( doesBallOnTop ) {

			ball.GetComponent<Rigidbody>().velocity = Vector3.zero;

			if ( Input.GetKey(KeyCode.Space) ) {
				doesBallOnTop = false;

				var ballRigidbody = ball.GetComponent<Rigidbody>();
				var velocity = ballRigidbody.velocity;
				ballRigidbody.velocity = new Vector3(velocity.x, 6.0f, 0.0f);
			}
			else {
				this.move();
				ball.transform.position = new Vector3(
					this.transform.position.x,
					ball.transform.position.y,
					0.0f
				);
			}
		}
		else {
			this.move();
		}
	}

	void move() {
		float x = Input.GetAxisRaw("Horizontal");
		float y = this.GetComponent<Rigidbody>().velocity.y;
		Vector2 direction = new Vector3(x, y, 0).normalized;
		this.GetComponent<Rigidbody>().velocity = direction * speed;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Ball") {
			GameObject ball     = collision.gameObject;
			Rigidbody rigidbody = ball.GetComponent<Rigidbody>();
			Vector3 velocity    = rigidbody.velocity;

			var point = collision.contacts[0].point;
			var barX  = this.transform.position.x - point.x;

			rigidbody.velocity  = new Vector3(
				barX * -10.0f,
				6.0f,
				velocity.z
			).normalized * speed;
		}
	}
	
}
