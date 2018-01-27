using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {

 //   [SerializeField]
 //   RoomManager[] Rooms;
 //   [SerializeField]
 //   //amount of rooms in a building
 //   float BuildingRooms;
 //   [SerializeField]
 //   float CurrentCharge;
 //   [SerializeField]
 //   float CurrentUsage;
 //   [SerializeField]
 //   int NumberTurnedOn;
 //   [SerializeField]
 //   int Difficulty;
 //   [SerializeField]
 //   bool StartCoroutine = false;
 //   Random Rand;
 //   [SerializeField]
 //   Electronics PoweredObject;
 //   [SerializeField]
 //   ElectricityGauge electricityGauge;
 //   [SerializeField]
 //   GameManager GameManagerScript;
    

	//// Use this for initialization
	//void Start ()
 //   {
 //       Rand = new Random();
 //       if (GameManagerScript.Difficulty == "Easy")
 //       {
 //           Difficulty = 3;
 //       }

 //       else if (GameManagerScript.Difficulty == "Medium")
 //       {
 //           Difficulty = 4;
 //       }

 //       else if (GameManagerScript.Difficulty == "Hard")
 //       {
 //           Difficulty = 5;
 //       }
 //   }

 //   // Update is called once per frame
 //   void Update ()
 //   {
 //       CurrentCharge = electricityGauge.Charge;
 //       if (!StartCoroutine)
 //       {
 //           TurnOffObjects();
 //           StartCoroutine("SetStartCoroutineBool");
 //       }
 //       else
 //       {
 //           PowerObjects();
 //       }
	//}
 //   //Look at the array of rooms and calculate what objects we are going to power
 //   void PowerObjects()
 //   {
        
 //       //StartCoroutine("ChangeElectronicsTimer");

 //       //DEBUG ONLY
 //       Difficulty = 3;
 //       int random = (int)Random.Range(1, Difficulty); //selects how many objects we will turn on this round

 //       for (int i = 0; i < random; i++)
 //       {
 //           int random2 = (int)Random.Range(1, BuildingRooms);
 //           for (int j = 0; j < Rooms[random2].GetComponent<RoomManager>().ElectricItems.Length; j++)
 //           {
 //               PoweredObject = Rooms[random2].GetComponent<RoomManager>().ElectricItems[j];
 //               if ((PoweredObject.PowerUsage + CurrentUsage) <= electricityGauge.Capacity) //checks to see if we will be beyond capacity if we add this object
 //               {
 //                   PoweredObject.TurnedOn = true;
 //                   NumberTurnedOn++;
 //                   break;
 //               }
 //           }
 //       }

 //       StartCoroutine = false;
 //       //PoweredObject = Rooms[random].GetComponent<RoomManager>().GetComponent<Electronics>();
 //       //if ((PoweredObject.PowerUsage += CurrentPower) >= 5)
 //       //{
 //       //    PoweredObject.GetComponent<MeshRenderer>().enabled = true;
 //       //}

 //       //StartCoroutine("PowerElectronicsTimer");
 //   }

 //   void TurnOffObjects()
 //   {
 //       for (int i = 0; i < Rooms.Length; i++)
 //       {
 //           for (int j = 0; j < Rooms[i].GetComponent<RoomManager>().ElectricItems.Length; j++)
 //           {
 //               PoweredObject = Rooms[i].GetComponent<RoomManager>().ElectricItems[j];

 //               if (PoweredObject.TurnedOn)
 //               {
 //                   PoweredObject.TurnedOn = false;
 //               }
 //           }
 //       }
 //       NumberTurnedOn = 0;
 //   }

 //   IEnumerator PowerElectronicsTimer()
 //   {
 //       yield return new WaitForSeconds(3.0f);
 //       CurrentUsage -= PoweredObject.PowerUsage * Time.deltaTime;
 //       PoweredObject.enabled = false;
 //   }

 //   //IEnumerator TurnOffObjectsCoRoutine()
 //   //{
 //   //    yield return new WaitForSeconds(3.0f);
 //   //    TurnOffObjects();

 //   //}
 //   IEnumerator SetStartCoroutineBool()
 //   {
 //       yield return new WaitForSeconds(3.0f);
 //       StartCoroutine = true;
 //   }
 //   IEnumerator ChangeElectronicsTimer()
 //   {
 //       yield return new WaitForSeconds(3.0f);

 //       //DEBUG ONLY
 //       Difficulty = 3;
 //       int random = (int)Random.Range(1, Difficulty); //selects how many objects we will turn on this round

 //       for (int i = 0; i < random; i++)
 //       {
 //           int random2 = (int)Random.Range(1, BuildingRooms);
 //           for (int j = 0; j < Rooms[random2].GetComponent<RoomManager>().ElectricItems.Length; j++)
 //           {
 //               PoweredObject = Rooms[random2].GetComponent<RoomManager>().ElectricItems[j];
 //               if ((PoweredObject.PowerUsage + CurrentUsage) <= electricityGauge.Capacity) //checks to see if we will be beyond capacity if we add this object
 //               {
 //                   PoweredObject.TurnedOn = true;
 //                   NumberTurnedOn++;
 //                   break;
 //               }
 //           }
 //       }

 //       StartCoroutine = false;
    //}
}
