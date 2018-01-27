using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {



    public void PlayGame() //Function to Run the first level
    {
        StartCoroutine(WaitForNextScene());
        //SceneManager.LoadScene("Credits");//Load first level.
    }

    public void QuitGame()//Function to quit the game.
    {
        Debug.Log ("You have just quit the game");
        Application.Quit();//Exit the application.
    }

    IEnumerator WaitForNextScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);

    }
}
