using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneAudio : MonoBehaviour {

    public float time;
    bool dish = true;
    bool wash = true;
    bool dish2 = true;

    
	// Use this for initialization
	void Start () {
        AudioManager audio = FindObjectOfType<AudioManager>();
        audio.Play("LowPower");
        audio.Play("AMB");
    }
	
	// Update is called once per frame
	void Update () {
        time +=Time.deltaTime;
        if (time > 8&& dish)
        {
            AudioManager audio = FindObjectOfType<AudioManager>();
            audio.Play("Dishes");
            dish = false;
        }
        if(time > 17&& wash)
        {
            AudioManager audio = FindObjectOfType<AudioManager>();
            audio.Play("Washer");
            wash = false;
        }
        if (time > 21 && dish2)
        {
            AudioManager audio = FindObjectOfType<AudioManager>();
            audio.Play("Dishes");
            dish = false;
        }
    }
}
