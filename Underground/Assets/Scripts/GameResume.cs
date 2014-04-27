using UnityEngine;
using System.Collections;

public class GameResume : MonoBehaviour 
{
	// Game resume button functions and behaviour
    public bool isExit = false;

    void Start()
    {
        Screen.showCursor = true;
    }

    void OnMouseEnter()
    {
        guiText.material.color = Color.green;
    }

    void OnMouseExit()
    {
        guiText.material.color = new Color32(255,255,255,255);
    }

    void OnMouseUp()
    {
        if (isExit)
        {
            Application.LoadLevel(0);
        }
        else
        {
            Application.LoadLevel(1);
            Time.timeScale = 1;
        }
    }
}
