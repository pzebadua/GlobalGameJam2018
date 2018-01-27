using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpManager : MonoBehaviour
{

    public int StoreDegen;
    public int DoubleCapacityNumber;
    public bool AnyKeyAccess;
    int powerupcooldown;
    
    ElectricityGauge EG;
    bool powerupused;
    [SerializeField]
    Text pctext;
    // Use this for initialization
    void Start()
    {
        EG = GetComponent<ElectricityGauge>();
        pctext = GameObject.FindGameObjectWithTag("PowerUpTag").GetComponent<Text>();
        
        AnyKeyAccess = false;
    }

    // Update is called once per frame
    void Update()
    {
       
            StopDegen();
            DoubleCapacity();
            AnyKeyPress();
        
    }
    void StopDegen()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))//access the charge variable, store the degen variable in temp variable, set it to 0, start coroutine, after coroutine reset the degen rate to the stored variable
        {
            powerupused = true;
            StartCoroutine(PowerUpCooldown());
            powerupused = false;
        }

    }
    void DoubleCapacity()
    {
        //Access the Capacity, store the capacity in a temp
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EG.Capacity = 200.0f;
            StartCoroutine(PowerUpCooldown());
            EG.Capacity = 100.0f;

        }


    }
    void AnyKeyPress()
    {

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {//the AnyKeyAccess bool turns true which switchs the usable keys for adding power to the bank to any key for the duration of the usage coroutine the turns off afterwards
            AnyKeyAccess = true;
            StartCoroutine(PowerUpUsingTimer());
            AnyKeyAccess = false;
            powerupused = true;
            StartCoroutine(PowerUpCooldown());
            powerupused = false;
        }

    }
    IEnumerator PowerUpCooldown()
    {
        yield return new WaitForSeconds(10.0f);
        powerupused = false;

    }
    IEnumerator PowerUpUsingTimer()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
