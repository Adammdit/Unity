using UnityEngine;
using System.Collections;

public class HUDpistol : MonoBehaviour 
{
    public GUIText mytext;
    private float posX = 0.4f, posY = 0.03f;

	// Defines sprite position and display ammo number
	void Update () 
    {
        transform.position = new Vector3(posX, posY, 1);
        mytext.text = "" + Player.ammoPistol;
	}
}
