using UnityEngine;
using System.Collections;

public class Robot1 : MonoBehaviour 
{
    //public bool hit = false;
    private float livePoints = 100;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Raycasting();
        Behaviours();

	    if (livePoints < 1)
        {
            DestroyObject();
        }
	}

    void Raycasting()
    {
        

        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up);
            if (hit)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                livePoints = livePoints - 20;
            }
        }
    }

    void Behaviours()
    {

    }

    /*
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet")
        {
            Debug.Log("XXXXXXXXX");
            //coll.gameObject.SendMessage("ApplyDamage", 10);
            livePoints = livePoints - 10;
            

        }
    }
    */

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
