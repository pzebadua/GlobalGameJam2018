﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {


	// Use this for initialization
	void Start () {
        AudioManager audio = GetComponent<AudioManager>();
        audio.Play("BGM");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
