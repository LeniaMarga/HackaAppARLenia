using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR 
using UnityEditor;
#endif
using UnityEngine;
using Vuforia;
using System.Linq;

public class ShowInitialText : MonoBehaviour
{

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable
    public Texture focusTexture;
   //public Texture2D texture;
  // public Rect position;

    private void OnGUI()
    {
        // guiStyle.fontSize = 24; //change the font size
        // guiStyle.normal.background = texture;

        // string myString = "Σκαναρε τον Hacka!";
        //  int textWidth = myString.Length * 10;


        //GUI.Label(new Rect(Screen.width /2  - textWidth / 2, Screen.height/2 , textWidth, 40), myString, guiStyle);
        //  EditorGUI.LabelField(position, GUIContent.none, guiStyle);



        if (!GetComponent<TrackableList>().activeTrackables.Any())
            {
            //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 120, 50), "Message goes here");
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), focusTexture, ScaleMode.StretchToFill);
        }
        else
            {
              
            }


            

        }



}