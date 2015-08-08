using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {
	private Rigidbody2D player;
	private int health = 100;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D>();
	}

	void OnGUI () {
		if(GUI.Button (new Rect (10,10,150,100), "Health: " + health)){
		};
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			health -= 10;

			Debug.Log("Player was hit!");
		}
	}
}
