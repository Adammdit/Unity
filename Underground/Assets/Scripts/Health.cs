using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
    private int playerHealthPrevious = 100;
    private Vector2 endPoint = new Vector2(-8, -10);
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
	    if(Player.health < playerHealthPrevious)
        {
            endPoint.x -= 0.26f;
            lineRenderer.SetPosition(1, endPoint);
            playerHealthPrevious = Player.health;
        }
	}
}
