using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailState : MonoBehaviour
{
    [SerializeField]
    pauseMenu PauseMenu;
    [SerializeField]
    GameObject GameOverMenu;

    public void GameOver()
    {
        //Trigger game over screen
        PauseMenu.GameOver();
        GameOverMenu.SetActive(true);
    }
	
}
