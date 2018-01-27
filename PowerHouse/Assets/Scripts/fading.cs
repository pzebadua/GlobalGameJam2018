using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class fading : MonoBehaviour {

    public Texture2D fadeOutTexture;                   // texture that will fill screen, black image for us.
    public float fadespeed = 0.8f;                     // the speed the scene will fade. 

    private int drawDepth = -1000;                     // the textures order in the draw hiearchy, the lower the number it will render on top.
    private float alpha = 1.0f;                        // the textures alpha value between 0 and 1.
    private int fadeDir = -1;                          // the direction to fade : in = -1 or out = 1

    private void OnGUI()
    {
        alpha += fadeDir * fadespeed * Time.deltaTime;
        //fade out/in the alpha value using a direction, a speed and Time.deltatime to convert the operation to seconds.

        alpha = Mathf.Clamp01(alpha);
        //force the number between 0 and 1 because GUI.color uses alpha values between 0 and 1.


        //setting color of our texture, all color values are the same & alpha is set to the alpha variable.
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);             // set the alpha value.
        GUI.depth = drawDepth;                                                           // make the black texture render on top.
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);    // draw the texture to fit the entire screen area.

    }

    //set fadeDir (fade direction) to the direction parameter, making the scene fade in if -1 and out if 1
    public float BeginFade (int direction)
    {
        fadeDir = direction;
        return (fadespeed);
    }

    IEnumerator WaitForNextScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("credits");

    }

}
