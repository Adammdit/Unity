using UnityEngine;
using System.Collections;

public class AmmoShotgun : MonoBehaviour 
{
    private bool flag = false;

	// Triggers sound adds ammo and destroy it self
    void OnCollisionEnter2D()
    {
        if (!flag)
        {
            audio.Play();
            Player.ammoShotgun += 25;
            Destroy(gameObject, 0.2f);
            flag = true;
        }
    }
}
