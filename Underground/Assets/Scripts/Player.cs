using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    Animator anim;
    public static int playerScore = 0;
    public static float playerHealth = 100;
    public static int ammoPistol = 0;
    public static int ammoShotgun = 0;
    private bool flag = true;
    public static bool pistol = true;
    public static bool shotgunCollected = false;
    public AudioClip pistolFire;
    public AudioClip shotgunFire;
    public AudioClip dryClick;
    public AudioClip playerHit;
    public GameObject bullet;
    private GameObject tempBullet;

	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector2 (0, 5);
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        if(pistol)
        {
            anim.SetBool("Shotgun", false);
            if (Input.GetMouseButtonDown(0) && ammoPistol > 0) // 0 means left click
            {
                audio.clip = pistolFire;
                audio.Play();
                tempBullet = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;
                ammoPistol--;
                anim.SetBool("Ammo", true);
            }
            else if (Input.GetMouseButtonDown(0) && ammoPistol <= 0)
            {
                audio.clip = dryClick;
                audio.Play();
                anim.SetBool("Ammo", false);
            }
        }
        else
        {
            anim.SetBool("Shotgun", true);
            if (Input.GetMouseButtonDown(0) && ammoShotgun > 0) // 0 means left click
            {
                audio.clip = shotgunFire;
                audio.Play();
                tempBullet = (Instantiate(bullet, transform.position, transform.rotation)) as GameObject;
                ammoShotgun--;
                anim.SetBool("Ammo", true);
            }
            else if (Input.GetMouseButtonDown(0) && ammoShotgun <= 0)
            {
                audio.clip = dryClick;
                audio.Play();
                anim.SetBool("Ammo", false);
            }
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

        if (playerHealth <= 0)
        {
            //Destroy(gameObject, 5);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemie")
        {           
            playerHealth -= 10;
            //audio.clip = playerHit;
            PlayHitAudio();
            //playerHit.audio.Play();
        }
    }

    void PlayHitAudio ()
    {
        audio.PlayOneShot(playerHit);
    }
}
