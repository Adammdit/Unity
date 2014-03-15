using UnityEngine;
using System.Collections;

public class Robot2 : MonoBehaviour
{
    //public bool hit = false;
    private float livePoints = 100;
    public GameObject go;
    private int layerMaskWall = 1 << 12;

    void Start()
    {
        go = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (livePoints < 1)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)) // 0 means left click
        {
            RaycastHit2D obsticle = Physics2D.Linecast(transform.position, go.transform.position, layerMaskWall);
            if (!obsticle)
            {
                livePoints -= 35;
            }
        }
    }
}

