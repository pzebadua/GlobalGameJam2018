using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {

    [SerializeField]
    RoomManager[] Rooms;
    [SerializeField]
    //amount of rooms in a building
    float BuildingRooms;
    [SerializeField]
    float CurrentPower;
    Random Rand;
    [SerializeField]
    Electronics PoweredObject;
    [SerializeField]
    ElectricityGauge electricityGauge;
    //[SerializeField]
    //GameManager GameManagerScript;
    

	// Use this for initialization
	void Start ()
    {
        Rand = new Random();
	}
	
	// Update is called once per frame
	void Update ()
    {
        CurrentPower = electricityGauge.Charge;
        PowerObjects();
	}
    //Look at the array of rooms and calculate what objects we are going to power
    void PowerObjects()
    {
        //if (GameManagerScript.Difficulty == "Easy")
        //{

        //}

        //else if (GameManagerScript.Difficulty == "Medium")
        //{

        //}

        //else if (GameManagerScript.Difficulty == "Hard")
        //{

        //}
        int random = (int)Random.Range(0, BuildingRooms);
        PoweredObject = Rooms[random].GetComponent<RoomManager>().GetComponent<Electronics>();
        if ((PoweredObject.PowerUsage += CurrentPower) >= 5)
        {
            PoweredObject.GetComponent<MeshRenderer>().enabled = true;
        }

        StartCoroutine("PowerElectronicsTimer");
    }

    IEnumerator PowerElectronicsTimer()
    {
        yield return new WaitForSeconds(3.0f);
        CurrentPower -= PoweredObject.PowerUsage;
        PoweredObject.enabled = false;
    }
}
