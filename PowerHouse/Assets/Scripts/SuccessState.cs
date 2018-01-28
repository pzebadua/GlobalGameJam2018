using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessState : MonoBehaviour {
    public bool Winstate;
    public LevelTimeline LT;
    public ScoreBoard SB;
    [SerializeField]
    int LevelTime;
	// Use this for initialization
	void Start () {
        Winstate = false;
        LT.LevelLength = LevelTime;
    }
	
	// Update is called once per frame
	void Update () {
        BeattheLevel();	
	}
    void BeattheLevel()
    {
        if (/*SB.GetPlayerScore() >= 45000 &&*/ LevelTime <= LT.CurrentSeconds)
        {
            Winstate = true;
        }
    }

}
