using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce = 100f;

	private bool isStart;

	public Rigidbody2D rBody;

	void Start () {
		
	}

	void Update () {

			if (Input.GetMouseButtonDown (0)) {

				if (!isStart) {
					isStart = true;
					rBody.gravityScale = 1;
				}

			if (!GetComponent<Trigger>().gameOver) {
					rBody.velocity = Vector2.zero;
					rBody.AddForce (new Vector2 (0, jumpForce));
				}

			}
	}

	void FixedUpdate()
	{
		if (isStart) {

			heavyEnd ();
		}
	}

	public void heavyEnd()
	{
		float angle = 35;
		if (rBody.velocity.y < 0) {
			angle = Mathf.Lerp (35, 0, -(rBody.velocity.y) / 10);
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
	}
		
}
