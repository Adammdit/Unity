using UnityEngine;
using System.Collections;

public class ScreenFrame : MonoBehaviour 
{
    public GUITexture frame;

	// Defines position and size of screen frame
	void Update() 
    {
        frame.pixelInset = new Rect(0, 0, Screen.width, Screen.height);
	}
}
