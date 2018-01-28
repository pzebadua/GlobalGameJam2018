using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Displaycharge : MonoBehaviour
{

    [SerializeField]
    Text text;
    public ElectricityGauge EG;   
    // Use this for initialization
    void Start()
    {
       if (text == null && GetComponent<Text>() != null)
        {
            text = GetComponent<Text>();
        }
       // EG = GetComponent<ElectricityGauge>();

    }

    void ShowCharge()
    {
        text.text = "Charge: " + EG.GetCharge().ToString();
    }
    // Update is called once per frame
    void Update()
    {
        ShowCharge();
    }
}
