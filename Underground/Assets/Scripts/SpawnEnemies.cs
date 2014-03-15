using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

    public GameObject enemie1;
    public GameObject enemie2;

	// Use this for initialization
	void Start () 
    {
        GameObject temp;
        for (int i = 1; i <= Random.Range(3, 6); i++)
        {
            temp = (Instantiate(enemie2, new Vector2(Random.Range(30f, 40f), Random.Range(-3f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            temp.name = "enemy2-" + i;
            temp = (Instantiate(enemie1, new Vector2(Random.Range(0f, 10f), Random.Range(-8f, 8f)), Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward))) as GameObject;
            temp.name = "enemy1-" + i;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
