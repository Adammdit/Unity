using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour 
{
    public float positionZ = -5;
    public float smoothTime = 0.3f;
    private Vector3 velocity;
    private float pos;
    public GameObject player; // Find object Player and make instance of it
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 16)
        {
            pos = Mathf.SmoothDamp(transform.position.x, 38f, ref velocity.x, smoothTime);
            transform.position = new Vector3(pos, 0f, -10f);
        }
        else
        {
            transform.position = new Vector3(0f, 0f, -10f);
        }
    }
}
