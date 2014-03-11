using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
    // Find object Player and make instance of it
    public GameObject go;

	void Start ()
    {
        go = GameObject.Find("Player");
        
	}
	
	// Update is called once per frame
    void FixedUpdate()
	{
        // Change position to Player position
        transform.position = go.transform.position;
        // Change rotation to Player rotation
        transform.rotation = go.transform.rotation;
        // Correct position by subtracting 90 degrees of rotation along Z axis
        transform.rotation *= Quaternion.Euler(0, 0, -90);
        // Offset the bullet position that it's comming out of the gun position instead of center of character
        transform.Translate(Vector2.up * -15 * Time.deltaTime);
        transform.Translate(Vector2.right * -12 * Time.deltaTime);
	}
}
