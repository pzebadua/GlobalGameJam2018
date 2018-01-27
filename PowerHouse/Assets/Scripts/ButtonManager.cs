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
    Random rand;
    // Use this for initialization
    void Start()
    {
        Aabletopress = true;
        Sabletopress = true;
        Dabletopress = true;
        Jabletopress = true;
        Kabletopress = true;
        Labletopress = true;
        rand = new Random();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonPress();
    }
    void ButtonPress()
    {
     

        if (Input.GetKeyDown(KeyCode.A) && Aabletopress == true)
        {
            addPower += addPowerAddition;
            Aabletopress = false;
            Abutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.A) && Dbutton)
        {
            Aabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && Sabletopress == true)
        {
            addPower += addPowerAddition;
            Sabletopress = false;
            Sbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.S) && Abutton)
        {
            Sabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.D) && Dabletopress == true)
        {
            addPower += addPowerAddition;
            Dabletopress = false;
            Dbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.D) && Jbutton)
        {
            Dabletopress = true;
        }
        if (Input.GetKeyDown(KeyCode.J) && Jabletopress == true)
        {
            addPower += addPowerAddition;
            Jabletopress = false;
            Jbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.J) && Sbutton)
        {
            Jabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && Kabletopress == true)
        {
            addPower += addPowerAddition;
            Kabletopress = false;
            Kbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.K) && Kbutton)
        {
            Aabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.L) && Labletopress == true)
        {
            addPower += addPowerAddition;
            Labletopress = false;
            Lbutton = true;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.L) && Abutton)
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
