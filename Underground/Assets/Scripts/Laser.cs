using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
    // Find object Player and make instance of it
    public GameObject go;
    private Vector2 endPoint;

	void Start ()
    {
        go = GameObject.Find("Player");        
	}
	
	// Update is called once per frame
    void FixedUpdate()
	{
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up);
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        // Change position to Player position
        transform.position = go.transform.position;
        // Change rotation to Player rotation
        transform.rotation = go.transform.rotation;
        // Offset the laser position that it's comming out of the gun position
        transform.Translate(Vector2.right * -16 * Time.deltaTime);
        transform.Translate(Vector2.up * 10 * Time.deltaTime);
        // Set end points
        if(hit)
        {
            endPoint = hit.collider.gameObject.transform.position;
        }
        endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPoint);
	}
}
