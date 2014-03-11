using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public float positionX;
    public float positionY;

    void Start()
    {

    }

    void FixedUpdate()
    {

        transform.position += transform.up * bulletSpeed * Time.deltaTime;

        
    }
    // Makes bullet available to shoot again
    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
    /*
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "robot1")
        {
            Debug.Log("XXXXXXXXX");
            //coll.gameObject.SendMessage("ApplyDamage", 10);
            Destroy(coll.gameObject); // destroys enemy
            
        }
    }
     

    void OnCollisionEnter2D()
    {
        rigidbody2D.velocity = Vector2.zero;
        bulletSpeed = 0f;
        transform.Translate(Vector2.zero);
    }
    */



}
