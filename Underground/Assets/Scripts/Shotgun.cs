using UnityEngine;
using System.Collections;

public class Shotgun : MonoBehaviour 
{
    private bool flag = false;

	// Triggers audio, add ammo, destroy
    void OnCollisionEnter2D()
    {
        if (!flag)
        {
            Player.shotgunCollected = true;
            //Player.pistol = false;
            flag = true;
            audio.Play();
            Player.ammoShotgun += 25;
            Destroy(gameObject, 1);            
        }
    }
}
