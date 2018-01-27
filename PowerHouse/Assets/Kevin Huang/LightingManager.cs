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
	
    public void InvertLight()
    {
        on = !on;
        if(on == true)
        {
            thisLight.enabled = true;
        }
        else if(on == false)
        {
            thisLight.enabled = false; 
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvertLight();
        }
	}
}
