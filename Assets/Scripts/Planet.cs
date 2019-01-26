using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet : MonoBehaviour {

	[SerializeField] int maxPeople = 0;
	[SerializeField] int currentPeople = 0;
	[SerializeField] Slider mySlider;

	void Awake(){
		mySlider.maxValue = maxPeople;
	}

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "Human" && currentPeople < maxPeople) {
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
