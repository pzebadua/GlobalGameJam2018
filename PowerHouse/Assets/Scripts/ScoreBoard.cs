using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    bool GreenBarmultiplier;
   public int playerscore;
    int tempscore;
   

    public ElectricityGauge EG;
   
    // Use this for initialization
    void Start()
    {
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
        if (EG.GetCharge() >= 51 && EG.GetCharge() <= 80)
        {
            GreenBarmultiplier = true;
            playerscore += 4;
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
        if (EG.GetCharge() >= 25 || EG.GetCharge() <= 50)
        {
            playerscore+=2;
        }
        else if (EG.GetCharge() <= 24 && EG.GetCharge() >= 0)
        {
            playerscore++;
        }
    }
    void BadSpot()
    {
        if (EG.Charge >= 81)
        {
            playerscore -= 1;
        }
        if (playerscore <= 0)
        {
            Mathf.Clamp(playerscore, 0, int.MaxValue);
        }
    }
    public int GetPlayerScore()
    {
        return playerscore;
    }
}
