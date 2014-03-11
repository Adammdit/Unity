using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{	
	public float maxSpeed = 3f;
	//Transform playerTransform = player.transform;
	Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{       
		float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
		
		anim.SetFloat ("SpeedX", Mathf.Abs(moveX));
		anim.SetFloat ("SpeedY", Mathf.Abs(moveY));
		
        rigidbody2D.velocity = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
		
        // Sprite facing mouse coursor
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10.0f; //The distance from the camera to the player object
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = (Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg) - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            anim.SetBool("Trigger", true);
        }
    }
}
