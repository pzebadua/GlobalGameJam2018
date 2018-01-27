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
    public bool Combo1Complete;
    protected bool Combo2Complete;
    protected bool Combo3Complete;
    public int combo1completion;

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
        if (Input.GetKeyDown(KeyCode.A))
        {
            Combo1Part1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.J) && Combo1Part1 == true)
        {
            Combo1Part2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) && Combo1Part2 == true)
        {
            Combo1Part3 = true;
        }
        else if (Input.GetKeyDown(KeyCode.K) && Combo1Part3 == true)
        {
            Combo1Part4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && Combo1Part4 == true)
        {
            Combo1Part5 = true;
        }
        else if (Input.GetKeyDown(KeyCode.L) && Combo1Part5 == true)
        {
            Combo1Complete = true;
            Combo1Part1 = false;
            Combo1Part2 = false;
            Combo1Part3 = false;
            Combo1Part4 = false;
            Combo1Part5 = false;
            StartCoroutine(WaitAfterCompletion());
        }


    }
    void ComboNumberTwo()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Combo2Part1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.K) && Combo2Part1 == true)
        {
            Combo2Part2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.J) && Combo2Part2 == true)
        {
            Combo2Part3 = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) && Combo2Part3 == true)
        {
            Combo2Part4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && Combo2Part4 == true)
        {
            Combo2Part5 = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && Combo2Part5 == true)
        {
            Combo2Complete = true;
            Combo2Part1 = false;
            Combo2Part2 = false;
            Combo2Part3 = false;
            Combo2Part4 = false;
            Combo2Part5 = false;
            StartCoroutine(WaitAfterCompletion());
        }
    }
    void ComboNumberThree()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Combo3Part1 = true;
        }
        else if (Input.GetKeyDown(KeyCode.J) && Combo3Part1 == true)
        {
            Combo3Part2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) && Combo3Part2 == true)
        {
            Combo3Part3 = true;
        }
        else if (Input.GetKeyDown(KeyCode.K) && Combo3Part3 == true)
        {
            Combo3Part4 = true;
        }
        else if (Input.GetKeyDown(KeyCode.L) && Combo3Part4 == true)
        {
            Combo3Part5 = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && Combo3Part5 == true)
        {
            Combo3Complete = true;
            Combo3Part1 = false;
            Combo3Part2 = false;
            Combo3Part3 = false;
            Combo3Part4 = false;
            Combo3Part5 = false;
            StartCoroutine(WaitAfterCompletion());
        }
    }
    IEnumerator WaitAfterCompletion()
    {
        yield return new WaitForSeconds(1.0f);
        Combo1Complete = false;
    }
}
