using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
    public bool isExit = false;

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
            Application.Quit();
        }
        else
        {
            Application.LoadLevel(1);
        }
    }

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
