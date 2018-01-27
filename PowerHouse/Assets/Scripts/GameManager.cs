using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string Difficulty = "";

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Scene scene = SceneManager.GetActiveScene();

        //Level One = Easy/Tutorial
		if (scene.name == "Level 1")
        {
            Difficulty = "Easy";
        }

        else if (scene.name == "Level 2")
        {
            Difficulty = "Medium";
        }

        else if (scene.name == "Level 3")
        {
            Difficulty = "Hard";
        }
    }
}
