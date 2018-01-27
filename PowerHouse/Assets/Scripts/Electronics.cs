using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electronics : MonoBehaviour {

    [SerializeField]
    //How much power the device needs
    float PowerUsage;
    [SerializeField]
    bool TurnedOn;
    [SerializeField]
    //Time the object should turn on in seconds
    int TurnOnTime; 
    [SerializeField]
    //duration the object should be turned on
    float Duration;
    //duration the object has been turned on
    [SerializeField]
    float OnDuration;
    [SerializeField]
    ElectricityGauge electricityGauge;
    [SerializeField]
    Material OnMaterial;
    [SerializeField]
    Material OffMaterial;
    [SerializeField]
    LevelTimeline levelTimeline;
    bool HasBeenUsed = false;

    void Update()
    {
        if ((levelTimeline.CurrentSeconds >= TurnOnTime) && !HasBeenUsed)
        {
            TurnedOn = true;
        }
        if (TurnedOn && (OnDuration <= Duration))
        {
            GetComponent<MeshRenderer>().material = OnMaterial;
            electricityGauge.Charge -= PowerUsage*Time.deltaTime;
            OnDuration += 1 * Time.deltaTime;
            HasBeenUsed = true;
        }
        if (OnDuration >= Duration)
        {
            GetComponent<MeshRenderer>().material = OffMaterial;
            TurnedOn = false;
            OnDuration = 0;

        }
    }
    private void Start()
    {
        TurnedOn = false;
    }

    float GetPowerUsage()
    {
        return PowerUsage;
    }

    void SetPowerUsage(float _PowerUsage)
    {
        PowerUsage = _PowerUsage;
    }

    void LackOfPower()
    {
        //has less power than needed and about to shut off
        //animation to get more dim.
    }

    void TriggerTimeline()
    {

    }
}
