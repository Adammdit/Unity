using UnityEngine;
using System.Collections;

public class HUDscore : MonoBehaviour 
{
    public GUIText mytext;
    private float posX = 0.75f, posY = 0.065f;

	// Defines sprite position and display score number
    void Update()
    {
        transform.position = new Vector3(posX, posY, 1);
        mytext.text = "" + Player.playerScore;
    }
}
