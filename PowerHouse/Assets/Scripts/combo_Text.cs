using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combo_Text : MonoBehaviour {
    [SerializeField]
    Text text;
    ComboManager CM;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text = FindObjectOfType<Text>();
        CM = GetComponent<ComboManager>();

	}	
	// Update is called once per frame
	void Update ()
    {
        ShowCombo();
	}
    void ShowCombo()
    {
        text.text = CM.combo1completion.ToString();
    }
}
