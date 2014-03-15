using UnityEngine;
using System.Collections;

public class Robot1 : MonoBehaviour 
{
    //public bool hit = false;
    private float livePoints = 100;
    public GameObject go;
    private int layerMaskWall = 1 << 12;

    void Start ()
    {
        go = GameObject.Find("Player"); 
	}
    

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
            RaycastHit2D obsticle = Physics2D.Linecast(transform.position, go.transform.position, layerMaskWall);         
            RaycastHit2D hitRobot = Physics2D.Raycast(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (hitRobot && !obsticle)
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
