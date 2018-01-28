using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {



    public void PlayGame() //Function to Run the first level
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()//Function to quit the game.
    {
        Debug.Log ("You have just quit the game");
        Application.Quit();//Exit the application.
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
    }

    
}
