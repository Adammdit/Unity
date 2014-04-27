using UnityEngine;
using System.Collections;

public class Robot3 : MonoBehaviour 
{
    public GameObject player;
    Animator anim;
    private int targetLayer = 1 << 9;
    private float maxSpeed = 3;
    private float livePoints = 200;
    private int mask = 14336; // Mask for binary 12 or 13 or 14 layers
    private bool soundplayed = false;
    private float angle;

    public AudioClip clipDie;
    public AudioClip clipHit;

    private AudioSource audioDie;
    private AudioSource audioHit;

    // Function to play sounds  
    AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float vol) 
    {
        AudioSource newAudio = (AudioSource)GetComponent(typeof(AudioSource));
        newAudio.clip = clip;
        newAudio.loop = loop;
        newAudio.playOnAwake = playAwake;
        newAudio.volume = vol;
        return newAudio;
    }
    
    void Awake()
    {
        // Add the necessary AudioSources:
        audioDie = AddAudio(clipDie, false, true, 1f);
        audioHit = AddAudio(clipHit, false, true, 1f);
    }
    
    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		// Checks if lifePoints are grater than 0 and triggers different animations
        if (livePoints < 1)
        {
            if (!soundplayed)
            {
                Player.playerScore += 100;
                audioDie.PlayOneShot(clipDie);
                soundplayed = true;
            }
            anim.SetBool("Die", true);

            Destroy(gameObject, 0.75f);
        }
        else
        {
            anim.SetBool("Die", false);
            // Raycast against player's layer
            RaycastHit2D hit = Physics2D.Raycast(transform.position, (player.transform.position - transform.position).normalized, 10, targetLayer);
            if (hit)
            {
                anim.SetBool("Walk", true);
                // Rotate towards moving player
                Vector3 moveDirection = (player.transform.position - transform.position).normalized;
                if (moveDirection != Vector3.zero)
                {
                    angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                }
                // Move towards player
                transform.Translate((player.transform.position + transform.position).normalized * maxSpeed * Time.deltaTime);
            }
            else
            {
                anim.SetBool("Walk", false);
            }
        }
    }

    void OnMouseOver()
    {
		// Enemy raycasting against player and checks is there any obsticles on the line.
		// Obsticles are represented by mask combined out of three different layers.
        RaycastHit2D obsticle = Physics2D.Linecast(transform.position, player.transform.position, mask);
        if (Input.GetMouseButtonDown(0) && Player.pistol && Player.ammoPistol > 0) // 0 means left click
        {
            if (!obsticle)
            {
                livePoints -= 20;
                anim.SetBool("Hit", true);
                audioDie.PlayOneShot(clipHit);
            }
        }
        else if (Input.GetMouseButtonDown(0) && !Player.pistol && Player.ammoShotgun > 0)
        {
            if (!obsticle)
            {
                livePoints -= 50;
                anim.SetBool("Hit", true);
            }
        }
        else
        {
            anim.SetBool("Hit", false);
        }
    }

	// On collision with player triggers animation
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            anim.SetBool("Attack", true);
        }
    }
}
