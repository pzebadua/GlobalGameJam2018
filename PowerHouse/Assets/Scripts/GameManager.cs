using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string Difficulty = "";
    [SerializeField]
    ElectricityGauge electricityGauge;
    [SerializeField]
    FailState failStateScript;

	// Use this for initialization
	void Start ()
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

    void Update()
    {
       if (electricityGauge.Charge <= 0 || electricityGauge.Charge >= 100)
        {
            Debug.Log("You lost!");
            failStateScript.GameOver();
        }
    }
}
