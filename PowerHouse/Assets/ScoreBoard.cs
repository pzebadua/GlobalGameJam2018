using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    float YellowBar;
    float GreenBar;
    float timeinsweetspot;
    bool GreenBarmultiplier;
    int playerscore;
   

    ElectricityGauge EG;
    ButtonManager BM;
    [SerializeField]
    Text text;
    // Use this for initialization
    void Start()
    {
        EG = GetComponent<ElectricityGauge>();
        BM = GetComponent<ButtonManager>();
        text = GameObject.FindGameObjectWithTag("ButtonTag").GetComponent<Text>();
        YellowBar = 0;
        GreenBar = 0;
        playerscore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        displayescore();
    }
    void updatescore()
    {
        SweetSpot();
        AverageSpot();
            
    }
    void displayescore()
    {
        updatescore();
        text.text = playerscore.ToString();
    }
    void SweetSpot()
    {
        //if (EG.Charge >= 51 || EG.Charge <= 80)
        if (EG.Charge >= 51 && EG.Charge <= 80)
        {
            GreenBarmultiplier = true;
            playerscore = playerscore + 2 * (int)Time.deltaTime;
        }
        else
        {
            GreenBarmultiplier = false;
        }
       


        //check to see how long the charge has been in the sweetspot and for the duration of charge staying in sweetspot a iterator increases

    }

    void AverageSpot()
    {
        if (EG.Charge >= 0 || EG.Charge <= 50)
        {
            playerscore++;
        }
    }
}
