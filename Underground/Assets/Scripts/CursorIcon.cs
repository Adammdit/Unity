using UnityEngine;
using System.Collections;

public class CursorIcon : MonoBehaviour 
{
    private float z;

    void Start()
    {      
        z = transform.position.z;       
    }
	// Replace default cursor with new one and defines it movement	
    void FixedUpdate()
    {
        Screen.showCursor = false;
        float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        transform.position = new Vector3(x, y, z);
    }
}
