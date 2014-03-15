using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Add this line, otherwise the List won't work

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    private Vector2 limits = new Vector3(0,-5,0);
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
        Destroy(gameObject,0.08f);
        /*
        RaycastHit2D hit = Physics2D.Raycast(transform.position, ((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized));
        if(hit)
        {
            
            if (Mathf.Abs(transform.position.x) > Mathf.Abs(hit.point.x) && Mathf.Abs(transform.position.y) > Mathf.Abs(hit.point.y))
            {
                //Destroy(gameObject);
            }
            
        }
        else
        {

        }
         */
    }

}
