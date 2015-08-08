using UnityEngine;
using System.Collections;

enum Directions {
	IDLE,
	UP,
	DOWN,
	LEFT,
	RIGHT
}

public class move : MonoBehaviour {
	private Rigidbody2D player;
	private Animator anim;

	public float maxSpeed = 10f;
	int faceDirection = (int) Directions.IDLE; 

	void Start () {
		player = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	void FixedUpdate () {
		float moveH = Input.GetAxis("Horizontal");
		float moveV = Input.GetAxis("Vertical");

		player.velocity = new Vector2(moveH * maxSpeed, moveV * maxSpeed);
		anim.SetFloat("Speed", Mathf.Abs(moveH) + Mathf.Abs(moveV));

		if(moveH > 0){
			if(faceDirection != (int) Directions.RIGHT)
				Flip();

			faceDirection = (int) Directions.RIGHT;
			anim.SetInteger("faceDirection", (int) Directions.RIGHT);
		} else if(moveH < 0){
			if(faceDirection != (int) Directions.LEFT)
				Flip();

			faceDirection = (int) Directions.LEFT;
			anim.SetInteger("faceDirection", (int) Directions.LEFT);
		}

		if(moveV > 0){
			faceDirection = (int) Directions.UP;
			anim.SetInteger("faceDirection", (int) Directions.UP);
		} else if(moveV < 0){
			faceDirection = (int) Directions.DOWN;
			anim.SetInteger("faceDirection", (int) Directions.DOWN);
		}

		if(moveH == 0 && moveV == 0){
			faceDirection = (int) Directions.IDLE;
			anim.SetInteger("faceDirection", (int) Directions.IDLE);
		}


	}

	void Flip(){
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
