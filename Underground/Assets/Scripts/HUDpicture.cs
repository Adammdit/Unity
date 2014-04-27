using UnityEngine;
using System.Collections;

public class HUDpicture : MonoBehaviour 
{
    private float posX = 0.2f, posY = 0.02f;
    
	// Defines pictures position
    void Update()
    {
        transform.position = new Vector3(posX, posY, 1);
    }
}
