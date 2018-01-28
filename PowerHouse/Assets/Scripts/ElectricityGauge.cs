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
    [Range(0, 100)]
    public float Charge;
    [SerializeField]
    ButtonManager ButtonScript;
    [SerializeField]
    GameObject Meter;

    void Start ()
    {
        //start the game at the "sweet spot" (75-80 charge)
        Charge = 50;
        Capacity = 100;
        Vector3 temp = transform.rotation.eulerAngles;
        temp.z = Charge * 1.8f;
        transform.rotation = Quaternion.Euler(temp);
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
        if ((Charge += ButtonScript.addPower) < 100) //TODO
        {
            Charge += ButtonScript.addPower;
            ButtonScript.addPower = 0;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = Charge * 1.8f;
            transform.rotation = Quaternion.Euler(temp);
        }
    }

    void DegenCharge()
    {
        if ((Charge += RegenRate * Time.deltaTime) < 100)
        {
            Charge += RegenRate * Time.deltaTime;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = Charge * 1.8f;
            transform.rotation = Quaternion.Euler(temp);
        }
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
    public int GetCharge()
    {

        return (int)Charge;
    }
}
