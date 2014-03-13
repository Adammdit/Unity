using UnityEngine;
using System.Collections;

public class Robot1 : MonoBehaviour 
{
    //public bool hit = false;
    private float livePoints = 100;
	
	// Update is called once per frame
	void Update ()
    {
        Raycasting();

	    if (livePoints < 1)
        {
            Destroy(gameObject);
        }
	}

    void Raycasting()
    {           
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {            
            RaycastHit2D hitRobot = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up);
            if (hitRobot)
            {                
                if (hitRobot.collider.gameObject.tag == "Enemie")
                {
                    Debug.Log("Target Position: " + hitRobot.collider.gameObject.transform.position);
                    livePoints -= 20;
                }               
            }
        }         
    }
}
