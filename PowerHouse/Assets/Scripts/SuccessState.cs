using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessState : MonoBehaviour {
    public bool Winstate;
    public LevelTimeline LT;
    public ScoreBoard SB;
    [SerializeField]
    int LevelTime;
    [SerializeField]
    int winscore;
	// Use this for initialization
	void Start ()
    {
        Winstate = false;
        LT.LevelLength = LevelTime;
    }
	
	// Update is called once per frame
	void Update () {
        BeattheLevel();	
	}
    void BeattheLevel()
    {
        if (SB.GetPlayerScore() >= winscore && LevelTime <= LT.CurrentSeconds)
        {
            SceneManager.LoadScene("MainMenu");
            Winstate = true;
        }
         
        
    }

}
