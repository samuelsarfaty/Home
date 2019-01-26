using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitatingObject : MonoBehaviour {

    public GameObject OrbitCenter;

    [Tooltip("Orbitatng speed, in units/second")]
    [Range(0, 100)]
    public float Speed = 50;

    // Use this for initialization
    void Start () {
        OrbitCenter = GameObject.FindWithTag("Earth");
    }
	
	// Update is called once per frame
	void Update () {
        //Rotate function
        transform.RotateAround(OrbitCenter.transform.position, Vector3.up, Speed * Time.deltaTime);
    }
}
