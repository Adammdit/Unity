using UnityEngine;
using System.Collections;

public class AmmoShotgun : MonoBehaviour {

    private bool flag = false;

    // Update is called once per frame
    void Update()
    {

    }
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
