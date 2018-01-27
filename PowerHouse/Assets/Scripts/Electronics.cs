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
    float OnDuration;
    [SerializeField]
    ElectricityGauge electricityGauge;
    [SerializeField]
    Material material;
    [SerializeField]
    LevelTimeline levelTimeline;

    void Update()
    {
        if (levelTimeline.CurrentSeconds == TurnOnTime)
        {
            TurnedOn = true;
        }
        if (TurnedOn && Duration <= OnDuration)
        {
            GetComponent<MeshRenderer>().material = material;
            electricityGauge.Charge -= PowerUsage*Time.deltaTime;
            Duration += 1 * Time.deltaTime;
        }
        if (OnDuration >= Duration)
        {
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
