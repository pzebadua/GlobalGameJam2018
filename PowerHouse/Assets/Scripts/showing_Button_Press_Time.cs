using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showing_Button_Press_Time : MonoBehaviour {
    [SerializeField]
    Text text;
    ButtonManager BM;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text = FindObjectOfType<Text>();
        BM = GetComponent<ButtonManager>();

	}
    private void Update()
    {
        Shownumbers();
    }
    // Update is called once per frame
    void Shownumbers()
    {
        text.text = BM.addPower.ToString();
    }
}
