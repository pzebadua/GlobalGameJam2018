using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingManager : MonoBehaviour {

    public Light thisLight;
    bool on;

	// Use this for initialization
	void Start () {
        thisLight = gameObject.GetComponent<Light>();
        thisLight.enabled = false;
        on = false;
	}
	
    public void TurnLightOn()
    {
        on = true;
        if(on == true)
        {
            FindObjectOfType<AudioManager>().Play("LightOn");
            thisLight.enabled = true;
        }
        
    }
    public void TurnLightOff()
    {
        if (on == true)
        {
            FindObjectOfType<AudioManager>().Play("LightOff");
        }
        on = false;
        thisLight.enabled = false;
    }
	// Update is called once per frame
	void Update () {
        
	}
}
