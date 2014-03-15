using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
    // Find object Player and make instance of it
    public GameObject go;
    private Vector2 endPoint;
    private int mask = 14336; // Mask for binary 12 or 13 or 14 layers

	void Start ()
    {
        go = GameObject.Find("Player");        
	}
	
	// Update is called once per frame
    void FixedUpdate()
	{
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        // Change position to Player position
        transform.position = go.transform.position;
        // Change rotation to Player rotation
        transform.rotation = go.transform.rotation;
        // Offset the laser position that it's comming out of the gun position
        transform.Translate(Vector2.right * -16 * Time.deltaTime);
        transform.Translate(Vector2.up * 10 * Time.deltaTime);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, ((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized), 1000, mask);
        lineRenderer.SetPosition(0, transform.position);
        if (hit)
        {           
			endPoint = hit.point;
			lineRenderer.SetPosition(1, endPoint);           
        }
	}
}
