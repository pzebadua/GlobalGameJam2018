﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimeline : MonoBehaviour
{
    [SerializeField]
    GameManager GameManagerScript;
    [SerializeField]
    Electronics[] electronics;
    [SerializeField]
    int Level;
    [SerializeField]
    public float CurrentSeconds; //current time in level
    [SerializeField]
   public float LevelLength; //duration of level
    [SerializeField]
    float CountdownTime; //time before level begins after it loads
    bool Countdown;


    // Use this for initialization
    void Start ()
    {
        CurrentSeconds = 0;
        Countdown = true;

        if (GameManagerScript.Difficulty == "Easy")
        {
            Level = 1;
            
        }

        else if (GameManagerScript.Difficulty == "Medium")
        {
            Level = 2;
           
        }

        else if (GameManagerScript.Difficulty == "Hard")
        {
            Level = 3;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!Countdown)
            CurrentSeconds += 1 * Time.deltaTime;
        else
        {
            CountdownTime -= 1 * Time.deltaTime;
        }

        if (CountdownTime <= 0)
        {
            Countdown = false;
        }
	}
}
