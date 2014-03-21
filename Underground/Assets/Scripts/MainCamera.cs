using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour 
{
    public float positionZ = -5;
    public float smoothTime = 0.3f;
    private Vector3 velocity;
    private float posX;
    private float posY;
    public GameObject player; // Find object Player and make instance of it

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.transform.position.x > 16 && player.transform.position.y < 11)
        {
            posX = Mathf.SmoothDamp(transform.position.x, 38f, ref velocity.x, smoothTime);
            transform.position = new Vector3(posX, 0f, -10f);
        }
        else if (player.transform.position.x < 16 && player.transform.position.y < 11)
        {
            transform.position = new Vector3(0f, 0f, -10f);
        }
        else if (player.transform.position.y > 11)
        {
            posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTime);
            posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTime);
            transform.position = new Vector3(posX, posY, -10f);
        }        
    }    
}
