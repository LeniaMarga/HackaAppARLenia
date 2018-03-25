using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInitialText : MonoBehaviour
{

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable

 

   

    private void OnGUI()
    {
        guiStyle.fontSize = 24; //change the font size
       GUILayout.Label("Write your text here.", guiStyle);

        string myString = "Σκαναρε τον Hacka!";
        int textWidth = myString.Length * 10;
        //10 is a constant which will obviously vary as you change the font or its size, 
        //so you'll need a little of pacience to get a good value there

        GUI.Label(new Rect(Screen.width / 2 - textWidth / 2, Screen.height / 2, textWidth, 40), myString, guiStyle);
      
    }


}