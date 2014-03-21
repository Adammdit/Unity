using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Add this line, otherwise the List won't work

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;

    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
        Destroy(gameObject,0.008f);
    }
}
