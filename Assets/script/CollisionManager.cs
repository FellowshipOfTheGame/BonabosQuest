using UnityEngine;
using System.Collections;

public class CollisionManager : MonoBehaviour {
	private Rigidbody2D player;
	static int health = 100;
	public int nextScene = 0;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D>();
	}

	void OnGUI () {
		if(GUI.Button (new Rect (10,10,100,50), "Health: " + health)){
		};
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			health -= 10;

			Debug.Log("Player was hit by an enemy!");
		}

		if (col.gameObject.tag == "GameController") {
			Application.LoadLevel(nextScene);
			
			Debug.Log("Transitioning to scene " + nextScene + "!");
		}
	}

	void Update(){
		if (health <= 0) {
			Application.LoadLevel("game_over");
			Debug.Log ("Player is dead!");
		}
	}
}
