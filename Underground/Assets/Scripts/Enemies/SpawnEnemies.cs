using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

    public GameObject temp;
    public GameObject enemie1;
    public GameObject enemie2;
    public GameObject ammoPistol;
    public GameObject ammoShotgun;
    private bool collected = false;
    private int i;

	// Use this for initialization
	void Start () 
    {
        // Instantiate basement creatures
        for (i = 1; i <= Random.Range(12, 13); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(30f, 40f), Random.Range(-4f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            //temp.name = "enemy2-" + i;
            temp = (Instantiate(enemie1, new Vector2(Random.Range(51f, 60f), Random.Range(29f, 38f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            //temp.name = "enemy1-" + i;
        }
        for (i = 1; i <= Random.Range(30, 50); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(24f, 40f), Random.Range(15f, 47f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            //temp.name = "enemy2-" + i;
            //temp = (Instantiate(enemie1, new Vector2(Random.Range(0f, 10f), Random.Range(-8f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            //temp.name = "enemy1-" + i;
        }
        // Instantiate Ammo
        temp = (Instantiate(ammoPistol, new Vector2(14, 5), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 6), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 7), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 8), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 9), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 10), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(27.5f, 9.5f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(27.5f, 8.5f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(27.5f, 7.5f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if (Player.shotgunCollected)
        {
            if (!collected)
            {
                //GameObject temp;
                for (i = 1; i <= Random.Range(10, 30); i++)
                {
                    temp = (Instantiate(enemie2, new Vector2(Random.Range(30f, 40f), Random.Range(-4f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 2*Mathf.PI), Vector3.forward))) as GameObject;
                    //temp.name = "enemy2-" + i;
                }
                collected = true;
            }
            
        }
	}
}
