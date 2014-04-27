using UnityEngine;
using System.Collections;

public class HUDhealth : MonoBehaviour 
{
    private float posX = 0.25f, posY = 0.02f;

    void Update()
    {
        transform.position = new Vector3(posX, posY, 1);
	}
	// Draws health bar on GUI
    void OnGUI()
    {
		if(Player.playerHealth > 0)
		{
			if (Player.playerHealth == 100)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 88, 18, 255, 0, 0);
			else if (Player.playerHealth == 90)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 79, 18, 255, 0, 0);
			else if (Player.playerHealth == 80)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 70, 18, 255, 0, 0);
			else if (Player.playerHealth == 70)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 61, 18, 255, 0, 0);
			else if (Player.playerHealth == 60)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 52, 18, 255, 0, 0);
			else if (Player.playerHealth == 50)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 44, 18, 255, 0, 0);
			else if (Player.playerHealth == 40)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 35, 18, 255, 0, 0);
			else if (Player.playerHealth == 30)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 26, 18, 255, 0, 0);
			else if (Player.playerHealth == 20)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 17, 18, 255, 0, 0);
			else if (Player.playerHealth == 10)
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 9, 18, 255, 0, 0);
			else
				HealthBar((posX * Screen.width) + 36, Screen.height - (posY * Screen.height) - 36, 0, 18, 255, 0, 0);
		}
    }
	// Function to draw health bar
	void HealthBar(float x, float y, int w, int h, float r, float g, float b)
	{
		Texture2D rgbTexture = new Texture2D(w, h);
        Color rgbColor = new Color(r, g, b);
        int i, j;
        for (i = 0; i < w; i++)
        {
            for (j = 0; j < h; j++)
            {
                rgbTexture.SetPixel(i, j, rgbColor);
            }
        }
        rgbTexture.Apply();
        GUIStyle genericStyle = new GUIStyle();
        GUI.skin.box = genericStyle;
        GUI.Box(new Rect(x, y, w, h), rgbTexture);
    }   
}
