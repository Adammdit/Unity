using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour 
{  
    public GameObject enemie1;
    public GameObject enemie2;
    public GameObject enemie3;
    public GameObject ammoPistol;
    public GameObject ammoShotgun;
    public GameObject player;
    private bool trap1 = false;
    private bool trap2 = false;
	private bool trap3 = false;
    private int i;

	// Use this for initialization
	void Start () 
    {
        player = GameObject.Find("Player");
        GameObject temp;

        // Instantiate all enenies
        for (i = 1; i <= Random.Range(10, 20); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(30f, 40f), Random.Range(-4f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            temp = (Instantiate(enemie1, new Vector2(Random.Range(51f, 60f), Random.Range(29f, 38f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
        }
        for (i = 1; i <= Random.Range(30, 50); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(24f, 40f), Random.Range(15f, 47f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;             
        }
        for (i = 1; i <= Random.Range(2, 5); i++)
        {
            temp = (Instantiate(enemie3, new Vector2(Random.Range(76f, 80f), Random.Range(23f, 27f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
        }
        for (i = 1; i <= Random.Range(10, 20); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(81f, 85f), Random.Range(49f, 56f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
        }
        for (i = 1; i <= Random.Range(20, 30); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(60f, 72f), Random.Range(51f, 58f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
        }

        // Instantiate all ammo
        temp = (Instantiate(ammoPistol, new Vector2(14, 5), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 6), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 7), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 8), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 9), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(14, 10), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(52, 52), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoPistol, new Vector2(122, 44), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
		temp = (Instantiate(ammoPistol, new Vector2(124, 44), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
		temp = (Instantiate(ammoShotgun, new Vector2(27.5f, 9.5f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(27.5f, 8.5f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(27.5f, 7.5f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(33f, 58f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(34f, 58f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(35f, 58f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(78f, 52f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(63f, 46f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
        temp = (Instantiate(ammoShotgun, new Vector2(63f, 38f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
		temp = (Instantiate(ammoShotgun, new Vector2(123f, 44f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
		temp = (Instantiate(ammoShotgun, new Vector2(123f, 45f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
		temp = (Instantiate(ammoShotgun, new Vector2(123f, 43f), Quaternion.AngleAxis(Random.Range(0, 0), Vector3.forward))) as GameObject;
	}
	
	// Checks player position and triggers traps
	void Update () 
    {
	    if (Player.shotgunCollected)
        {
            if (!trap1)
            {
                for (i = 1; i <= Random.Range(10, 30); i++)
                {
                    GameObject temp = (Instantiate(enemie2, new Vector2(Random.Range(30f, 40f), Random.Range(-4f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 2 * Mathf.PI), Vector3.forward))) as GameObject;
                }
                trap1 = true;
            }   
        }
        if(player.transform.position.x > 32 && player.transform.position.y > 57)
        {
            if (!trap2)
            {
                for (i = 1; i <= Random.Range(10, 20); i++)
                {
                    GameObject temp = (Instantiate(enemie2, new Vector2(Random.Range(33f, 44f), Random.Range(50f, 54f)), Quaternion.AngleAxis(Random.Range(0f, 2 * Mathf.PI), Vector3.forward))) as GameObject;
                }
                trap2 = true;
            }
        }
		if(player.transform.position.x > 121 && player.transform.position.x < 125 && player.transform.position.y > 42 && player.transform.position.y < 46)
		{
			if (!trap3)
			{
				for (i = 1; i <= Random.Range(5, 15); i++)
				{
					GameObject temp = (Instantiate(enemie2, new Vector2(Random.Range(105f, 109f), Random.Range(50f, 54f)), Quaternion.AngleAxis(Random.Range(0f, 2 * Mathf.PI), Vector3.forward))) as GameObject;
				}
				for (i = 1; i <= Random.Range(5, 15); i++)
				{
					GameObject temp = (Instantiate(enemie2, new Vector2(Random.Range(128f, 134f), Random.Range(53f, 57f)), Quaternion.AngleAxis(Random.Range(0f, 2 * Mathf.PI), Vector3.forward))) as GameObject;
				}
				for (i = 1; i <= Random.Range(20, 30); i++)
				{
					GameObject temp = (Instantiate(enemie2, new Vector2(Random.Range(119f, 130f), Random.Range(30f, 35f)), Quaternion.AngleAxis(Random.Range(0f, 2 * Mathf.PI), Vector3.forward))) as GameObject;
				}
				for (i = 1; i <= Random.Range(3, 5); i++)
				{
					GameObject temp = (Instantiate(enemie3, new Vector2(Random.Range(112f, 114f), Random.Range(41f, 50f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
				}
				trap3 = true;
			}
		}
	}
}