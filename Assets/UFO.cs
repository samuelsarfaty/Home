using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour {

    [Header("Physics")]
    public Rigidbody UFORigidbody;

    [Tooltip("Speed when moving forward, in units/second")]
    [Range(0, 100)]
    public float Speed = 50;

    [Tooltip("Torque applied when rotating, in Netwon*metre")]
    [Range(0, 100)]
    public float Torque = 1;

    [Tooltip("Max number of passengers that you can carry at the same time")]
    [Range(0, 100)]
    public int passengers;

	// Use this for initialization
	void Start () {
        UFORigidbody = GetComponent<Rigidbody>();
	}

    //Update used for physics
    private void FixedUpdate()
    {
        /* If the vertical axis is not zero,
         *  we move the spaceship.
         */
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            /* We add force in the "up" direction,
             * which points in the direction the spaceship is 
               pointing at.
             */
            UFORigidbody.AddForce(transform.forward * vertical * Speed);
        }

        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {

            UFORigidbody.AddTorque(transform.up * horizontal);
            

        }




    }

    // Update is called once per frame
    void Update () {
		
	}
}
