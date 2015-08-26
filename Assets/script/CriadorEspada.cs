using UnityEngine;
using System.Collections;

public class CriadorEspada : MonoBehaviour{
	PlayerManager player;


	public CriadorEspada(PlayerManager g){
		player = g;
	}

	public GameObject criar(){
			GameObject o = (GameObject) Instantiate(player.prefab, player.gameObject.transform.position, Quaternion.identity);
			ScriptEspada S = o.gameObject.GetComponent<ScriptEspada> () as ScriptEspada;
			S.arco = 90;

			switch(player.faceDirection){
				case (int) Directions.UP:
					S.inicio = 45;
					break;
				case (int) Directions.LEFT:
					S.inicio = 135;
					break;
				case (int) Directions.DOWN:
					S.inicio = 225;
					break;
				case (int) Directions.RIGHT:
					S.inicio = 315;
					break;
			}

			o.transform.parent = player.transform;
			return o;
	}
}
