using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoAudioTimeline : MonoBehaviour {

    public float time;
    bool washer = true;

	// Use this for initialization
	void Start () {
        AudioManager audio = FindObjectOfType<AudioManager>();
        audio.Play("Ambience");
        audio.Play("PowerUp");
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time > 10 && washer)
        {
            AudioManager audio = FindObjectOfType<AudioManager>();
            audio.Play("Washer");
            washer = false;
        }

	}
}
