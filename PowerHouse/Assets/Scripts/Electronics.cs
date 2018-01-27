using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electronics : MonoBehaviour {

    [SerializeField]
    //How much power the device needs
    public float PowerUsage;
    [SerializeField]
    //Current power that the device has
    float CurrentPower;

    float GetPowerUsage()
    {
        return PowerUsage;
    }

    void SetPowerUsage(float _PowerUsage)
    {
        PowerUsage = _PowerUsage;
    }

    float GetCurrentPower()
    {
        return CurrentPower;
    }

    void SetCurrentPower(float _CurrentPower)
    {
        CurrentPower = _CurrentPower;
    }
}
