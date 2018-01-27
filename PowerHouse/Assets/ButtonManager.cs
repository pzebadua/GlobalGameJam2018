using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    bool Wabletopress;
    bool Aabletopress;
    bool Sabletopress;
    bool Dabletopress;
    bool Wbutton;
    bool Sbutton;
    bool Abutton;
    bool Dbutton;
    public int addPower = 0;
    Random rand;
    // Use this for initialization
    void Start()
    {
        Wabletopress = true;
        Aabletopress = true;
        Sabletopress = true;
        Dabletopress = true;
        rand = new Random();
    }

    // Update is called once per frame
    void Update()
    {
        ButtonPress();
    }
    void ButtonPress()
    {
        if (Input.GetKeyDown(KeyCode.W) && Wabletopress == true)
        {
            ++addPower;
            Wabletopress = false;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.W) && Wabletopress == false)
        {
            Wabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.A) && Aabletopress == true)
        {
            ++addPower;
            Aabletopress = false;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.A) && Aabletopress == false)
        {
            Aabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && Sabletopress == true)
        {
            ++addPower;
            Sabletopress = false;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.S) && Sabletopress == false)
        {
            Sabletopress = true;
        }

        if (Input.GetKeyDown(KeyCode.D) && Dabletopress == true)
        {
            ++addPower;
            Dabletopress = false;
            StartCoroutine(WaitforPress());
        }
        else if (Input.GetKeyDown(KeyCode.D) && Dabletopress == false)
        {
            Dabletopress = true;
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
