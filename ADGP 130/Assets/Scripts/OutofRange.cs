using UnityEngine;
using System.Collections;

public class OutofRange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "enemy")
        {
            hit.transform.SendMessage("", SendMessageOptions.DontRequireReceiver);
        }
    }
}
