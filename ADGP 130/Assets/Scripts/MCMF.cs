using UnityEngine;
using System.Collections;

public class MCMF : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnGUI()
        {
            if (Input.GetMouseButtonDown(0) == true)
            {
              
            }
            //if retry button is pressed load scene 0 the game
            GUI.contentColor = Color.cyan;
            if (GUI.Button(new Rect(Screen.width / 7, Screen.height / 2 - 10, 100, 50), "Continue"))
            {
#pragma warning disable CS0618 // Type or member is obsolete
            int i = Application.loadedLevel;
            Application.LoadLevel(i + 1);
#pragma warning restore CS0618 // Type or member is obsolete
        }
            //and quit button
            else if (GUI.Button(new Rect(Screen.width / 7, Screen.height / 2 + 110, 100, 50), "Try Again"))
            {
            Application.LoadLevel(Application.loadedLevel);
            }
        }

    }
