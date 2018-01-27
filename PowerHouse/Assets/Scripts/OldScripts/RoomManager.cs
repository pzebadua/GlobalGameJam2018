using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    [SerializeField]
    public Electronics[] ElectricItems;
    [SerializeField]
    string RoomName;

    void Start()
    {
        RoomName = gameObject.name;
    }

}
