using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboManager : MonoBehaviour
{
    ButtonManager BM;
    float Timer;
    protected bool Combo1Part1;
    protected bool Combo1Part2;
    protected bool Combo1Part3;
    protected bool Combo1Part4;
    protected bool Combo1Part5;
    protected bool Combo1Part6;
    protected bool Combo2Part1;
    protected bool Combo2Part2;
    protected bool Combo2Part3;
    protected bool Combo2Part4;
    protected bool Combo2Part5;
    protected bool Combo2Part6;
    protected bool Combo3Part1;
    protected bool Combo3Part2;
    protected bool Combo3Part3;
    protected bool Combo3Part4;
    protected bool Combo3Part5;
    protected bool Combo3Part6;
    protected bool Combo1Complete;
    protected bool Combo2Complete;
    protected bool Combo3Complete;

    // Use this for initialization
    void Start()
    {
        BM = GetComponent<ButtonManager>();
        Combo1Part1 = false;
        Combo1Part2 = false;
        Combo1Part3 = false;
        Combo1Part4 = false;
        Combo1Part5 = false;
        Combo2Part1 = false;
        Combo2Part2 = false;
        Combo2Part3 = false;
        Combo2Part4 = false;
        Combo2Part5 = false;
        Combo3Part1 = false;
        Combo3Part2 = false;
        Combo3Part3 = false;
        Combo3Part4 = false;
        Combo3Part5 = false;
        Combo1Complete = false;
        Combo2Complete = false;
        Combo3Complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        ComboNumberOne();
    }
    void ComboNumberOne()
    {
        while (Timer <= 2.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Combo1Part1 = true;
            }
            if (Input.GetKeyDown(KeyCode.J) && Combo1Part1 == true)
            {
                Combo1Part2 = true;
            }
            if (Input.GetKeyDown(KeyCode.S) && Combo1Part2 == true)
            {
                Combo1Part3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K) && Combo1Part3 == true)
            {
                Combo1Part4 = true;
            }
            if (Input.GetKeyDown(KeyCode.D) && Combo1Part4 == true)
            {
                Combo1Part5 = true;
            }
            if (Input.GetKeyDown(KeyCode.L) && Combo1Part5 == true)
            {
                Combo1Complete = true;
            }
            Timer += 0.5f;
        }

    }
    void ComboNumberTwo()
    {

    }
    void ComboNumberThree()
    {

    }
}
