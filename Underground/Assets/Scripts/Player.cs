using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    Animator anim;
    public static int playerScore = 0;
    public static int playerHealth;
    public static int ammoPistol = 0;
    public static int ammoShotgun = 0;
    private bool flag = true;
    public static bool pistol = true;
    public static bool shotgunCollected = false;
    public static bool shootingBlocked = false;
    public AudioClip pistolFire;
    public AudioClip shotgunFire;
    public AudioClip dryClick;
    public AudioClip playerHit;
    public GameObject bullet;
    private GameObject tempBullet;

	// Use this for initialization
	void Start ()
	{
		playerHealth = 100;
        transform.position = new Vector2(-11, 5);
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		// If pistol selected and shoots triggers sounds, animation and instantiate bullet
        if(pistol)
        {
            anim.SetBool("Shotgun", false);
            if (Input.GetMouseButtonDown(0) && ammoPistol > 0 && !shootingBlocked) // 0 means left click
            {
                audio.clip = pistolFire;
                audio.Play();
             
                GameObject tempBullet = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;
                ammoPistol--;
                anim.SetBool("Ammo", true);
            }
            else if (Input.GetMouseButtonDown(0) && ammoPistol <= 0 && !shootingBlocked)
            {
                audio.clip = dryClick;
                audio.Play();
                anim.SetBool("Ammo", false);
            }
        }
        else
        {
			// If shotgun selected and shoots triggers sounds, animation and instantiate bullet
            anim.SetBool("Shotgun", true);
            if (Input.GetMouseButtonDown(0) && ammoShotgun > 0 && !shootingBlocked) // 0 means left click
            {
                audio.clip = shotgunFire;
                audio.Play();
                GameObject tempBullet2 = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;
                ammoShotgun--;
                anim.SetBool("Ammo", true);
            }
            else if (Input.GetMouseButtonDown(0) && ammoShotgun <= 0 && !shootingBlocked)
            {
                audio.clip = dryClick;
                audio.Play();
                anim.SetBool("Ammo", false);
            }
        }
		// Lift part simplye check player position. If it's over the lift - his position is transformed
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
	// Player checks for collisions with different enemies to decrease his health by particular number.
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemie" && playerHealth > 0)
        {
            AudioSource.PlayClipAtPoint(playerHit, new Vector3(transform.position.x, transform.position.y, 2));
            playerHealth -= 10;        
        }
        else if (coll.gameObject.tag == "Enemie-2" && playerHealth > 0)
        {
            playerHealth -= 30;
            AudioSource.PlayClipAtPoint(playerHit, new Vector3(transform.position.x, transform.position.y, 2));
        }
        else if (coll.gameObject.tag == "Enemie-3" && playerHealth > 0)
        {
            playerHealth -= 50;
            AudioSource.PlayClipAtPoint(playerHit, new Vector3(transform.position.x, transform.position.y, 2));
        }
    } 

}
