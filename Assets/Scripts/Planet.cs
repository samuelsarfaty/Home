using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

	[SerializeField] public int maxPeople = 0;
	[SerializeField] public int currentPeople = 0;
    [SerializeField] long pointsPerHuman;
    [SerializeField] Slider mySlider;

    public GameManager gManager;

    public GameObject OrbitCenter;

    [Tooltip("Orbitatng speed, in units/second")]
    [Range(0, 100)]
    public float Speed;

    void Awake(){
		mySlider.maxValue = maxPeople;
	}

    void Start()
    {
        OrbitCenter = GameObject.FindWithTag("Earth");
    }

    void Update()
    {
        transform.RotateAround(OrbitCenter.transform.position, Vector3.up, Speed * Time.deltaTime);
    }

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Human" && currentPeople < maxPeople) {
            //Add score to the Game manager
            gManager.Score += pointsPerHuman;
			currentPeople++;
			UpdatePeopleCounter ();
			Destroy (other.gameObject);
			SpawnHuman ();
		}
	}

	void UpdatePeopleCounter(){
		mySlider.value = currentPeople;
	}

	void SpawnHuman(){
		//Make people appear on the surface of the planet
	}


}
