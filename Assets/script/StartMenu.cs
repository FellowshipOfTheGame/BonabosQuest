using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
	void OnGUI () {
		if(GUI.Button(new Rect((Screen.width/2) - 75,(Screen.height/2) - 110, 150, 100), "Play the game!")){
			Application.LoadLevel("first_map");
		};
		
		if(GUI.Button(new Rect((Screen.width/2) - 75, (Screen.height/2) + 10, 150, 100), "Exit the game!")){
			Application.Quit();
		};
	}
}