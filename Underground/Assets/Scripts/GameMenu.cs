using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour 
{
    private float posX = 0.5f, posY = 0.5f;
    public static bool on = false;
    public Font font;
	public GUIText mytext;
	// Drives game menu functions.
    void Update()
    {
        if(!on)
        {
			// If player dies or "Esc" key pressed stops time and display menu.
            transform.position = new Vector3(posX, 10, 1);
            if (Input.GetKeyUp(KeyCode.Escape) || Player.playerHealth < 10)
            {
                Time.timeScale = 0;
                Player.shootingBlocked = true;
                on = true;
            }
        }
        else
        {
            Screen.showCursor = true;
            transform.position = new Vector3(posX, posY, 1);
            
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                Time.timeScale = 1;
                Player.shootingBlocked = false;
                on = false;
            }
        }           

    }

    void OnGUI()
    {
        GUI.skin.font = font;
		// Draws buttons on GUI and defines functionalities.
        if (on)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 100, 150, 40), "RESUME"))
            {
                Time.timeScale = 1;
                on = false;
                Player.shootingBlocked = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 40, 150, 40), "RESTART"))
            {
				// In case of "RESTART" option necessary variables will be reset.
                Time.timeScale = 1;
                Application.LoadLevel(1);
                Player.playerScore = 0;
                Player.ammoPistol = 0;
                Player.ammoShotgun = 0;
                Player.playerHealth = 100;
                Player.shotgunCollected = false;
                Player.shootingBlocked = false;
				Player.pistol = true;
                on = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 20, 150, 40), "QUIT"))
            {
                Application.LoadLevel(0);
            }
			// Displaye message if player died.
			if(Player.playerHealth <= 0)
			{
				mytext.text = "YOU HAVE DIED !!!";
			}
        }
    }

}
