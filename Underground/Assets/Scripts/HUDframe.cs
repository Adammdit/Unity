using UnityEngine;
using System.Collections;

public class HUDframe : MonoBehaviour 
{
    private float posXpistol = 0.394f, posYpistol = 0.02f;
    private float posXshotgun = 0.542f, posYshotgun = 0.02f;
    
	// Defines position for frame selecting weapon
    void Update()
    {
        if (Player.pistol)
        {
            transform.position = new Vector3(posXpistol, posYpistol, 1);
        }
        else
        {
            transform.position = new Vector3(posXshotgun, posYshotgun, 1);
        }
    }
}
