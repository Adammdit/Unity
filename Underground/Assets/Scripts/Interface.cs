using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour 
{
    GUIStyle myStyle = new GUIStyle();
    private float x, y, x1;


    private float posX = 0.69f, posY = 0.9f;
	// Update is called once per frame   
	void Update () 
    {
        transform.position = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y - 10.625f);

	    if(Input.GetKeyDown("1"))
        {
            Player.pistol = true;           
        }
        if(Input.GetKeyDown("2") && Player.shotgunCollected)
        {
            Player.pistol = false;           
        }
	}

    void FixedUpdate()
    {
        x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        transform.position = new Vector3(x, y, 0);
        // Unload unused assets (memory leaks)
        Resources.UnloadUnusedAssets();
    }

    void OnGUI()
    {


        if (Player.playerHealth == 100)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 88, 18, 255, 0, 0);
        else if (Player.playerHealth == 90)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 79, 18, 255, 0, 0);
        else if (Player.playerHealth == 80)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 70, 18, 255, 0, 0);
        else if (Player.playerHealth == 70)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 61, 18, 255, 0, 0);
        else if (Player.playerHealth == 60)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 52, 18, 255, 0, 0);
        else if (Player.playerHealth == 50)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 44, 18, 255, 0, 0);
        else if (Player.playerHealth == 40)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 35, 18, 255, 0, 0);
        else if (Player.playerHealth == 30)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 26, 18, 255, 0, 0);
        else if (Player.playerHealth == 20)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 17, 18, 255, 0, 0);
        else if (Player.playerHealth == 10)
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 9, 18, 255, 0, 0);
        else
            HealthBar(Screen.width / 2 - 360, Screen.height - 67, 0, 18, 255, 0, 0);

        if (Screen.width > 1024)
        {
            x1 = Screen.width - 1024;
        }
        myStyle.fontSize = 28;
        GUI.Label(new Rect((Screen.width + x1) * posX , Screen.height * posY, 100, 100), " " + Player.ammoPistol, myStyle);
       // GUI.Label(new Rect(Screen.width / 2 - 5, Screen.height - 75, 100, 100), " " + Player.ammoShotgun, myStyle);
        /*
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
        {
            print("You clicked the button!");
        }
         */
    }

    void HealthBar(int x, int y, int w, int h, float r, float g, float b)
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
