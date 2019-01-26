using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLooker : MonoBehaviour {

	private Transform cam;

	void Awake(){
		cam = GameObject.FindWithTag ("MainCamera").transform;
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (cam);
	}
}
