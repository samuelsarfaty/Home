using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    public GameObject OrbitCenter;

    [Tooltip("Orbitatng speed, in units/second")]
    [Range(0, 100)]
    public float Speed = 50;

    public float pushForce;

    // Use this for initialization
    void Start () {
        OrbitCenter = GameObject.FindWithTag("Earth");
    }
	
	// Update is called once per frame
	void Update () {
        //Rotate function
        transform.RotateAround(OrbitCenter.transform.position, Vector3.up, Speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody collidedObject = collision.gameObject.GetComponent<Rigidbody>();

        //Add force to the rigidbody
        if (collidedObject != null)
        {
            //Calculate the force direction (from asteroid to the pushed object)
            Vector3 forceDirection = collision.gameObject.transform.position - transform.position;

            collidedObject.AddForce(forceDirection * pushForce);
        }
    }
    
    }
