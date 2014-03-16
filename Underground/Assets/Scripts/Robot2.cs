using UnityEngine;
using System.Collections;

public class Robot2 : MonoBehaviour
{
    public GameObject go;
    Animator anim2;
    private int targetLayer = 1 << 9;
    private float maxSpeed = 2;
    private float livePoints = 100;   
    private int layerMaskWall = 1 << 12;
    private bool soundplayed = false;

    void Start()
    {
        go = GameObject.Find("Player");
        anim2 = GetComponent<Animator>();
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
            anim2.SetBool("Die", true);
            
            Destroy(gameObject, 0.75f);
             
        }
        else
        {
            anim2.SetBool("Die", false);
            // Raycast against players layer
            RaycastHit2D hit = Physics2D.Raycast(transform.position, (go.transform.position - transform.position).normalized, 10, targetLayer);
            if (hit)
            {
                anim2.SetBool("Walk", true);
                // Rotate towards moving player
                Vector3 moveDirection = (go.transform.position - transform.position).normalized;
                if (moveDirection != Vector3.zero)
                {
                    float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                }
                // Move towards player
                Debug.DrawLine(transform.position, go.transform.position);
                transform.Translate((go.transform.position - transform.position).normalized * maxSpeed * Time.deltaTime);
            }
            else
            {
                anim2.SetBool("Walk", false);
            }
        }
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            RaycastHit2D obsticle = Physics2D.Linecast(transform.position, go.transform.position, layerMaskWall);
            if (!obsticle)
            {
                livePoints -= 50;
                anim2.SetBool("Hit", true);
            }
        }
        else
        {
            anim2.SetBool("Hit", false);
        }
    }
}

