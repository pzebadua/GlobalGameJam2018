using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{
    [SerializeField]
    pauseMenu PauseMenu;
    [SerializeField]
    GameObject YouWinMenu;
    public SuccessState SS;

    public void GameOver()
    {
        if (SS.Winstate)
        {
            //Trigger game over screen
            PauseMenu.GameOver();
            YouWinMenu.SetActive(true);
        }

    }
}



