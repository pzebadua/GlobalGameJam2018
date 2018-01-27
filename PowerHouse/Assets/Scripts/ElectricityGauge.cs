using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectricityGauge : MonoBehaviour {

    [SerializeField]
    float DegenRate;
    [SerializeField]
    float Capacity;
    [SerializeField]
    //current charge value
    float Charge;
    [SerializeField]
    ButtonManager ButtonScript;

    void Start ()
    {
        //start the game at the "sweet spot" (75-80 charge)
        Charge = 75;
        Capacity = 100;
        GetComponent<Slider>().value = Charge;
	}
	
	// Update is called once per frame
	void Update ()
    {
        ComputeCharge();

        //check to see if there is no power or a power surge
		if (Charge <= 0)
        {
            NoPower();
        }
        else if (Charge >= 100)
        {
            PowerSurge();
        }

        DegenCharge();
    }

    //computes the charge to be added based on incoming input
    void ComputeCharge()
    {
        Charge += ButtonScript.addPower;
        GetComponent<Slider>().value = Charge;
    }

    void DegenCharge()
    {
        Charge -= DegenRate;
        GetComponent<Slider>().value = Charge;
    }

    //power limit hit at 100
    void PowerSurge()
    {

    }

    //power limit hit at 0
    void NoPower()
    {
        
    }
}
