using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{	
	public float maxSpeed = 3f;
    private float moveX, moveY, angle;
	Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}

	// Defines player movement
	void FixedUpdate () 
	{       
		moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
		
		anim.SetFloat ("SpeedX", Mathf.Abs(moveX));
		anim.SetFloat ("SpeedY", Mathf.Abs(moveY));
		
        rigidbody2D.velocity = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
		
        // Sprite facing mouse coursor
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10.0f; //The distance from the camera to the player object
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        angle = (Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg) - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Player.shootingBlocked) // 0 means left click
        {
            anim.SetBool("Trigger", true);
        }
    }
}
