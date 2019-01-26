using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int NumberOfPlanets;

    public long StartNumberOfHumans;

    public long NumberOfHumans;

    public float humanBreedSpeed;

    public long MaxNHumans;

    public int Score;

    public int secondsToDieRatio;

	// Use this for initialization
	void Start () {
        //Initialize variables
        Score = 0;
        NumberOfHumans = StartNumberOfHumans;
        //Caclualte the breeding speed to have the secoonds to die ratio defined
        humanBreedSpeed = (MaxNHumans - StartNumberOfHumans) / secondsToDieRatio;

        //Create the planets
    }
	
	// Update is called once per frame
	void Update () {
        if (NumberOfHumans >= MaxNHumans)
        {
            //GameOver
        }
        else
        {
            //Add more humans per second
            NumberOfHumans += (long) (Time.deltaTime * humanBreedSpeed);
            //Check the Score
        }
	}



    //We are not creating the planets procedurally anymore
    /*
    public void CreatePlanets()
    {
        for (int i = 0; i < NumberOfPlanets; i++)
        {

        }
    }
    */
}
