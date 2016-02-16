using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{

    bool lose = false;
    // Use this for initialization
    void Start()
    {
    }

    void OnGUI()
    {
        if (lose == true)
        {


            //if retry button is pressed load scene 0 the game
            GUI.contentColor = Color.green;
            if (GUI.Button(new Rect(Screen.width / 3, Screen.height / 2 - 10, 300, 100), "Try Again"))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(1);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            //and quit button
            if (GUI.Button(new Rect(Screen.width / 3, Screen.height / 2 + 110, 300, 100), "Quit"))
            {
                Application.Quit();
            }
        }
    }

}