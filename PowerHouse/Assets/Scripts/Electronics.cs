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
    int LightCooldownTimer;
    [SerializeField]
    ElectricityGauge electricityGauge;
    [SerializeField]
    LevelTimeline levelTimeline;
    bool HasBeenUsed = false;
    LightingManager myLight;

    void Update()
    {
        if (electricityGauge.Charge <= 0)
        {
            Debug.Log("You lost. Power reached 0");
            TurnedOn = false;
        }
        else if (electricityGauge.Charge >= 100)
        {
            Debug.Log("You lost. Power reached 100");
            TurnedOn = false;
        }

        if ((levelTimeline.CurrentSeconds >= TurnOnTime) && !HasBeenUsed)
        {
            FindObjectOfType<AudioManager>().Play("LightOn");
            TurnedOn = true;
            myLight.InvertLight();
        }
        if (TurnedOn && (OnDuration <= Duration)) //Checks to see if the light is turned on and still has duration left
        {
            electricityGauge.Charge -= PowerUsage*Time.deltaTime;
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = electricityGauge.Charge * 1.8f;
            transform.rotation = Quaternion.Euler(temp);
            OnDuration += 1 * Time.deltaTime;
            HasBeenUsed = true;
        }
        if (OnDuration >= Duration) //Check to see if the light has been on for longer than it's allowed duration
        {
            StartCoroutine("WaitCoroutine");
        }
    }
    private void Start()
    {
        myLight = GetComponent<LightingManager>();
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

    IEnumerator WaitCoroutine() //Cooldown for lights to reset and be able to be used again.
    {
        
        TurnedOn = false;
        OnDuration = 0;
        yield return new WaitForSeconds(LightCooldownTimer);
        HasBeenUsed = false;
    }
}
