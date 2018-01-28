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
    int tempscore;
   

    ElectricityGauge EG;
   
    // Use this for initialization
    void Start()
    {
        EG = GetComponent<ElectricityGauge>();
        YellowBar = 0;
        GreenBar = 0;
        playerscore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        updatescore();
    }
    void updatescore()
    {
        SweetSpot();
        AverageSpot();
        BadSpot();
            
    }
    
    void SweetSpot()
    {
        //if (EG.Charge >= 51 || EG.Charge <= 80)
        if (EG.Charge >= 51 && EG.Charge <= 80)
        {
            GreenBarmultiplier = true;
            playerscore += 2;
            tempscore = (int)Time.deltaTime;
            if ((int)Time.deltaTime - tempscore == 2 && GreenBarmultiplier)
            {
                playerscore *= 2;
            }
            else if ((int)Time.deltaTime - tempscore == 5 && GreenBarmultiplier)
            {
                playerscore *= 5;
            }
            else if ((int)Time.deltaTime - tempscore == 10 && GreenBarmultiplier)
            {
                playerscore *= 10;
            }
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
    void BadSpot()
    {
        if (EG.Charge >= 81)
        {
            playerscore -= 2;
        }
    }
}
