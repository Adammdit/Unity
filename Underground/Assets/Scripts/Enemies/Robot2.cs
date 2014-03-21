using UnityEngine;
using System.Collections;

public class Robot2 : MonoBehaviour
{
    public GameObject player;
    Animator anim;
    private int targetLayer = 1 << 9;
    private float maxSpeed = 2;
    private float livePoints = 100;
    private int mask = 14336; // Mask for binary 12 or 13 or 14 layers
    private bool soundplayed = false;
    private float angle;

    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (livePoints < 1)
        {
            if (!soundplayed)
            {
                audio.Play();
                soundplayed = true;
            }
            anim.SetBool("Die", true);
            
            Destroy(gameObject, 0.75f);            
        }
        else
        {
            anim.SetBool("Die", false);
            // Raycast against players layer
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
                Debug.DrawLine(transform.position, player.transform.position);
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
        RaycastHit2D obsticle = Physics2D.Linecast(transform.position, player.transform.position, mask);
        if (Input.GetMouseButtonDown(0) && Player.pistol && Player.ammoPistol > 0) // 0 means left click
        {
            if (!obsticle)
            {
                livePoints -= 50;
                anim.SetBool("Hit", true);
            }
        }
        else if (Input.GetMouseButtonDown(0) && !Player.pistol && Player.ammoShotgun > 0)
        {
            if (!obsticle)
            {
                livePoints -= 100;
                anim.SetBool("Hit", true);
            }
        }
        else
        {
            anim.SetBool("Hit", false);
        }
    }
}

