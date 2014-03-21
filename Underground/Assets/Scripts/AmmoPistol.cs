using UnityEngine;
using System.Collections;

public class AmmoPistol : MonoBehaviour {

    public AudioClip ammoCollect;
    private bool flag = false; 

	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter2D()
    {
        if (!flag)
        {
            //audio.Play();
            audio.PlayOneShot(ammoCollect);
            Player.ammoPistol += 25;
            Destroy(gameObject, 0.2f);
            flag = true;
        }               
    }
}
