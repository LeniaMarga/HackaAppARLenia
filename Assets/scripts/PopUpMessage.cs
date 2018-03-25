using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMessage : MonoBehaviour {

    private PopUpMessage popUpMessage;
    private Text yourText;

    // Use this for initialization
    void Start () {
        popUpMessage = this;
        Invoke("DisplayText", 2);
    }
	
	// Update is called once per frame
	//void Update () {
       
	//}

    void DisplayText()
    {
        yourText.text = "Hello";
    }
}
