using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    public static int playerScore = 0;
    public int playerLives = 3;
    private bool flag = true;

    public GameObject bullet;
	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector2 (0, 5);       
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            GameObject tempBullet;
            audio.Play();
            tempBullet = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;
        }

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
