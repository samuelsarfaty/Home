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

	void UpdatePeopleCounter(){
		mySlider.value = currentPeople;
	}


}
