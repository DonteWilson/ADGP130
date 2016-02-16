using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
    }

    void OnGUI()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent<AudioSource>().Play();
        }
        //if retry button is pressed load scene 0 the game
        GUI.contentColor = Color.white;
        if (GUI.Button(new Rect(Screen.width / 7, Screen.height / 2 - 10, 300, 100), "Start"))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(1);
#pragma warning restore CS0618 // Type or member is obsolete
        }
        //and quit button
        if (GUI.Button(new Rect(Screen.width / 7, Screen.height / 2 + 110, 300, 100), "Quit"))
        {
            Application.Quit();
        }
    }

}