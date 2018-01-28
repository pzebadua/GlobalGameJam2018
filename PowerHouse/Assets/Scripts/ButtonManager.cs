using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    bool Aabletopress;
    bool Sabletopress;
    bool Dabletopress;
    bool Jabletopress;
    bool Kabletopress;
    bool Labletopress;

    bool Sbutton;
    bool Abutton;
    bool Dbutton;
    bool Jbutton;
    bool Kbutton;
    bool Lbutton;
    public int addPower = 0;
    public int addPowerAddition = 0;
    public pauseMenu PM;
    // Use this for initialization
    void Start()
    {
        Aabletopress = true;
        Sabletopress = true;
        Dabletopress = true;
        Jabletopress = true;
        Kabletopress = true;
        Labletopress = true;
    }

    // Update is called once per frame
    void Update()
    {
        ButtonPress();
    }
    void ButtonPress()
    {
     

        if (Input.GetKeyDown(KeyCode.A) && Aabletopress == true && PM.GetGameIsPaused() == false)
        {
            addPower += addPowerAddition;
            Aabletopress = false;
            Abutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.A) && Dbutton && PM.GetGameIsPaused() == false)
        {
            Aabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && Sabletopress == true && PM.GetGameIsPaused() == false)
        {
            addPower += addPowerAddition;
            Sabletopress = false;
            Sbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.S) && Abutton && PM.GetGameIsPaused() == false)
        {
            Sabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.D) && Dabletopress == true && PM.GetGameIsPaused() == false)
        {
            addPower += addPowerAddition;
            Dabletopress = false;
            Dbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.D) && Jbutton && PM.GetGameIsPaused() == false)
        {
            Dabletopress = true;
        }
        if (Input.GetKeyDown(KeyCode.J) && Jabletopress == true && PM.GetGameIsPaused() == false)
        {
            addPower += addPowerAddition;
            Jabletopress = false;
            Jbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.J) && Sbutton && PM.GetGameIsPaused() == false)
        {
            Jabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && Kabletopress == true && PM.GetGameIsPaused() == false)
        {
            addPower += addPowerAddition;
            Kabletopress = false;
            Kbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.K) && Kbutton && PM.GetGameIsPaused() == false)
        {
            Aabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.L) && Labletopress == true && PM.GetGameIsPaused() == false)
        {
            addPower += addPowerAddition;
            Labletopress = false;
            Lbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.L) && Abutton && PM.GetGameIsPaused() == false)
        {
            Sabletopress = true;
        }

       
    }

    public int GetPower()
    {
        return addPower;
    }

    IEnumerator WaitforPress()
    {
        yield return new WaitForSeconds(0.65f);
    }



}
