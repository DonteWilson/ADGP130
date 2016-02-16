using UnityEngine;
using System.Collections;


public class cursor : MonoBehaviour



{




    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()

    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Input.mousePosition, 10);

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 8, Input.mousePosition.y + 11, +10));
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent<AudioSource>().Play();

            if (hit != null && hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
                //hit.collider.GetComponent<Health>().hp -= 1;
                Debug.Log("hit");

            }
        }


    }
}

    {                
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, +10));
    }

    public void Shoot()
    {
        Debug.Log("do it");
    }
}

