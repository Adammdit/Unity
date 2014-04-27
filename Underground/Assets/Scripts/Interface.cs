using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour 
{
	// Drives weapon changing and accessing game menu
	void Update () 
    {
        transform.position = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y - 10.625f);

	    if(Input.GetKeyDown("1"))
        {
            Player.pistol = true;           
        }
        if(Input.GetKeyDown("2") && Player.shotgunCollected)
        {
            Player.pistol = false;           
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
        }
		// Memory leaks
        Resources.UnloadUnusedAssets();
	}
}
