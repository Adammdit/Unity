using UnityEngine;
using System.Collections;

public class HUDShotgun : MonoBehaviour 
{
    public GUIText mytext;
    private float posX = 0.55f, posY = 0.032f;
	// Defines sprite position and display ammo number
	void Update () 
    {
        transform.position = new Vector3(posX, posY, 1);
        
	}

    void OnGUI()
    {
        mytext.text = "" + Player.ammoShotgun;
    }
}
