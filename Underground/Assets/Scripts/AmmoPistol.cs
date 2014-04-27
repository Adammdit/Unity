using UnityEngine;
using System.Collections;

public class AmmoPistol : MonoBehaviour 
{
    public AudioClip ammoCollect;
    private bool flag = false;

	// Triggers sound adds ammo and destroy it self
    void OnCollisionEnter2D()
    {
        if (!flag)
        {
            audio.PlayOneShot(ammoCollect);
            Player.ammoPistol += 25;
            Destroy(gameObject, 0.2f);
            flag = true;
        }               
    }
}
