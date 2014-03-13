using UnityEngine;
using System.Collections;

public class CursorIcon : MonoBehaviour {

    private float z;

    void Start()
    {
        Screen.showCursor = false;
        z = transform.position.z;
    }

    void FixedUpdate()
    {
        float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        transform.position = new Vector3(x, y, z);
    }
}
