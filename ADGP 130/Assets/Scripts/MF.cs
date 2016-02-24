using UnityEngine;
using System.Collections;

public class MF : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().Play();

    }
    void OnGUI()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {

        }
        //if retry button is pressed load scene 0 the game
        GUI.contentColor = Color.cyan;
        if (GUI.Button(new Rect(Screen.width / 7, Screen.height / 2 - 10, 100, 50), "Retry?"))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            int i = Application.loadedLevel;
            Application.LoadLevel(i);
#pragma warning restore CS0618 // Type or member is obsolete

        }
    }
}

