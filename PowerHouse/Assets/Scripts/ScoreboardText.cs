using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreboardText : MonoBehaviour
{

    [SerializeField]
    Text text;
    public ScoreBoard SB;
    // Use this for initialization
    void Start()
    {
        if (text == null && GetComponent<Text>() != null)
        {
            text = GetComponent<Text>();
        }

    }
    void Showscore()
    {
        text.text = SB.GetPlayerScore().ToString();
    }
    // Update is called once per frame
    void Update()
    {
        Showscore();
    }
    
}
