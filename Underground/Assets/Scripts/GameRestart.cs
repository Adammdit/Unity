using UnityEngine;
using System.Collections;

public class GameRestart : MonoBehaviour 
{
	// Game restart button functions and behaviour
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
        guiText.material.color = new Color32(255, 255, 255, 255);
    }

    void OnMouseUp()
    {
        if (isExit)
        {
            Application.LoadLevel(1);
            Player.playerScore = 0;
            Player.ammoPistol = 0;
            Player.ammoShotgun = 0;
            Time.timeScale = 1;
        }
    }
}
