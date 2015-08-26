using UnityEngine;
using System.Collections;

public class ScriptEspada : MonoBehaviour {
		public float inicio = 45;
		public float arco = 90;
		private float Fim;
		public float rot = 1f;
		private float aux;
		private bool live;
		// Use this for initialization
		void Start (){
			Fim = (inicio + arco)%360;
			transform.Rotate(0,0,inicio);
			live = true;
		}
		
		// Update is called once per frame
		void Update () {
			aux =  transform.rotation.eulerAngles.z;
			
			aux = (aux < 0 ? -1 * aux : aux);
			
			if ( estaEntre(10,Fim,aux) )
				if( aux > Fim )
					live = false;
	
		if (!live)
			Destroy (this.gameObject);
	
		transform.Rotate (new Vector3 (0, 0, rot));
		}
		
		bool estaEntre(float c,float var,float e){
			if (e < var-c || e > var + c)
				return false;
			return true;
		}


}
