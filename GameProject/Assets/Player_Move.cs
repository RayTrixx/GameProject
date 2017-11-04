using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	public int playerSpeed = 10;
	public bool faceRight = true;
	public int playerJumpPower = 1250;
	public float moveX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerMove ();
	}

	void playerMove() {
		//CONTROLS
		moveX = Input.GetAxis("Horizontal");
		//ANIMATIONS
		//PLAYER DIRECTION
		if (moveX < 0.0f && faceRight == false) {
			flipPlayer ();
		} else if (moveX > 0.0f && faceRight == true) {
			flipPlayer ();
		}
		//PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void Jump() {
		
	}

	void flipPlayer () {
		faceRight = !faceRight;
		Vector2 lscale = gameObject.transform.localScale;
		lscale.x *= -1;
		transform.localScale = lscale;
	}

}
