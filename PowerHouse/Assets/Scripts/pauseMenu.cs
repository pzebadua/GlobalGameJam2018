using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    void Start()
    {
        GameIsPaused = false;
    }
    //This with tell us if the game is paused or not, we set it to not be on (false) as default.
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
	// Use this for initialization
	public void Update () {
        //If you press Escape the game will pause, if its paused we will Resume() game. If not then we will Pause().
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("we have quit the game");
        Application.Quit();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public bool GetGameIsPaused()
    {
        return GameIsPaused;
    }
}
