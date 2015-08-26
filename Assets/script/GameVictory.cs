using UnityEngine;
using System.Collections;

public class GameVictory : MonoBehaviour {
	void OnGUI () {
		if(GUI.Button(new Rect((Screen.width/2) - 75,(Screen.height/2) - 110, 150, 100), "You won the game!")){
			//TODO
		};
		
		if(GUI.Button(new Rect((Screen.width/2) - 75, (Screen.height/2) + 10, 150, 100), "Exit the game!")){
			Application.Quit();
		};
	}
}
