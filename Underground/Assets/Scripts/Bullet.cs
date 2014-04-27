using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;

	// Defines bullet movment and destroy it
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
        Destroy(gameObject,0.008f);
    }
}
