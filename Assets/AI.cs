using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	private GameObject player;
	private Rigidbody2D enemy;

	public float maxSpeed = 2f;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Character");
		enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		moveToPlayer();
	}
	
	void moveToPlayer(){
		float difX = player.transform.position.x - enemy.transform.position.x;
		float difY = player.transform.position.y - enemy.transform.position.y;

		float xSpeed, ySpeed;

		if (difX < -0.1){
			xSpeed = -maxSpeed;
		}else if(difX > 0.1){
			xSpeed = maxSpeed;
		}else{
			xSpeed = 0;
		}

		if(difY < -0.1){
			ySpeed = -maxSpeed;
		}else if(difY > 0.1){
			ySpeed = maxSpeed;
		}else{
			ySpeed = 0;
		}

		enemy.velocity = new Vector2(xSpeed, ySpeed);
	}
}
