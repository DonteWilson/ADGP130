using UnityEngine;
using System.Collections;

public class Killcount1 : MonoBehaviour {

    public int kills = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Input.mousePosition, 10);
        
        if (kills == 1 && hit != null && hit.collider != null)
        {
            
            
            hit.collider.gameObject.GetComponent<MC>().enabled = true;
        }
        
	}
}
