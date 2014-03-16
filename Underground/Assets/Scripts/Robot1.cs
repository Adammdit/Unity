using UnityEngine;
using System.Collections;

public class Robot1 : MonoBehaviour 
{
    public GameObject go;
    Animator anim;
    private float maxSpeed = 2;
    private float livePoints = 100;    
    private int layerMaskWall = 1 << 12;
    private int targetLayer = 1 << 9;
    

    void Start ()
    {
        go = GameObject.Find("Player");
        anim = GetComponent<Animator>();
	}
    

	// Update is called once per frame
	void Update ()
    {
        
	    if (livePoints <= 0)
        {
            Destroy();            
        }

        // Raycast against players layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, (go.transform.position - transform.position).normalized, 10, targetLayer);
        if (hit)
        {
            anim.SetBool("Walk", true);
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
            anim.SetBool("Walk", false);
        }
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            RaycastHit2D obsticle = Physics2D.Linecast(transform.position, go.transform.position, layerMaskWall);
            if (!obsticle)
            {
                audio.Play();    
                livePoints -= 20;   
            }
        }
    }

    void Destroy()
    {
        audio.Play();
        anim.SetBool("Die", true);
        
        Destroy(gameObject,0.8f);
    }
}
