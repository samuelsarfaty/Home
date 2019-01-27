using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerTrigger : MonoBehaviour {

	private MeshRenderer earthRenderer;

	void Awake(){
		earthRenderer = GameObject.FindWithTag ("Earth").GetComponentInChildren<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(earthRenderer.isVisible){
			//print ("I see earth");
		} else {
			//print ("no earth");
		}
	}
}
