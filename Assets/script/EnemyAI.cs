using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	private GameObject player;
	private Rigidbody2D enemy;

	public float maxSpeed = 5f;
	public float minSpeed = 2f;

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

		float xSpeed = difX;
		float ySpeed = difY;

		if (difX > 0.01 && difX < minSpeed) {
			xSpeed = minSpeed;
		}else if(difX > 0.01 && difX > maxSpeed){
			xSpeed = maxSpeed;
		}else if(difX < -0.01 && difX > -minSpeed){
			xSpeed = -minSpeed;
		}else if(difX < -0.01 && difX < -maxSpeed){
			xSpeed = -maxSpeed;
		}else if(difX > -0.01 && difX < 0.01){
			xSpeed = 0;
		}

		if (difY > 0.01 && difY < minSpeed) {
			ySpeed = minSpeed;
		}else if(difY > 0.01 && difY > maxSpeed){
			ySpeed = maxSpeed;
		}else if(difY < -0.01 && difY > -minSpeed){
			ySpeed = -minSpeed;
		}else if(difY < -0.01 && difY < -maxSpeed){
			ySpeed = -maxSpeed;
		}else if(difY > -0.01 && difY < 0.01){
			ySpeed = 0;
		}

		enemy.velocity = new Vector2(xSpeed, ySpeed);
	}
}
