using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectricityGauge : MonoBehaviour {

    [SerializeField]
    float RegenRate;
    [SerializeField]
    public float Capacity;
    //current charge value
    public float Charge;
    [SerializeField]
    ButtonManager ButtonScript;

    void Start ()
    {
        //start the game at the "sweet spot" (75-80 charge)
        Charge = 50;
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
        ButtonScript.addPower = 0;
        GetComponent<Slider>().value = Charge;
    }

    void DegenCharge()
    {
        Charge += RegenRate*Time.deltaTime;
        GetComponent<Slider>().value = Charge;
    }

    //power limit hit at 100
    void PowerSurge()
    {
        Debug.Log("Yo you lost");
    }

    //power limit hit at 0
    void NoPower()
    {
        Debug.Log("Yo we dont have power");
    }
}
