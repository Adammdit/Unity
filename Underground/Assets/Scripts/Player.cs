using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    private bool flag = true;
	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector2 (0, 5);
        audio.Play();
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (transform.position.x > 12.7f && transform.position.x < 14.2f && transform.position.y > -7.4f && transform.position.y < -5.6f && flag)
        {
            transform.position = new Vector2(50.5f, -5.5f);
            flag = false;
        }
        else if (transform.position.x < 49 && transform.position.x > 48)
        {
            flag = true;
        }
        else if (transform.position.x > 49.9f && transform.position.x < 51.3f && transform.position.y > -6.3f && transform.position.y < -4.8f && flag)
        {
            transform.position = new Vector2(13.5f, -6.5f);
            flag = false;
        }
        else if (transform.position.x < 12 && transform.position.x > 11)
        {
            flag = true;
        }
	}	
}
