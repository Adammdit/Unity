using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Add this line, otherwise the List won't work
 
public class Shooting : MonoBehaviour
{
    public float bulletSpeed = 50f;
    public GameObject player; // Find object Player and make instance of it
    public GameObject bullet; // Drag and drop your x axis bullet here
    //public AudioClip handGunShot;
    List<GameObject> bulletList; // This is a List of bullets, you can just think it as an array at this point
    // For more information of List, check the tut here:
    // http://unity3d.com/learn/tutorials/modules/intermediate/scripting/lists-and-dictionaries
    // It's short (5 mins) and informative
    public int maxBulletOnX = 8; // The limit of bullet on x axis 
    // You can always adjust the limit in inspector without going into the code
 
    void Start ()
    {
        
        player = GameObject.Find("Player");
        bullet = GameObject.Find("Bullet");
        bulletList = new List<GameObject>();
        for (int i = 0; i < maxBulletOnX; i++)
        {
            // bulletList.Add(Instantiate(bullet, transform.position, transform.rotation) as GameObject);
            bulletList.Add(Instantiate(bullet, Vector2.zero, Quaternion.identity) as GameObject);
            // What this line does is to "instantiate" the prefab (aka. your bullet you want to shoot)
            // Instantiate is good for cloning duplicated object like bullet
            // For more information of Instantiate, check here:            
            // http://docs.unity3d.com/Documentation/Manual/InstantiatingPrefabs.html
            // It's usually bad to instantiate/destroy at runtime, but you don't have to worry about it at this point
            bulletList[i].GetComponent<Bullet>().bulletSpeed = bulletSpeed;
            // This line will access your bullet's script and set the speed for it.
            // For more information of accessing another script, check here:
            // http://unitygems.com/script-interaction1/           
            bulletList[i].SetActive(false);
            // This will de-activate your bullet when started up
       }
    }
 
    void Shoot ()
    {
        

        GameObject temp = bulletList.Find(go => go.activeInHierarchy == false);
       // This is called lambda expression. You don't have to know what this is now.
       // What it does is to find bullet that is waiting to be used.
       if (temp != null)
       {
           // Change rotation to Player rotation
           temp.transform.rotation = player.transform.rotation;
           // Correct position by subtracting 90 degrees of rotation along Z axis
           //temp.transform.rotation *= Quaternion.Euler(0, 0, 90);
           // Change position to Player position
           temp.transform.position = player.transform.position;
           //temp.transform.position = new Vector2(player.transform.position.x - 0.4f, player.transform.position.y + 0.5f);
           //temp.transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
           // What this does is to set the bullet at right place, aka where you shoot
           // Now it shoots from the center of your character
           // Offset the bullet position that it's comming out of the gun position instead of center of character
           temp.transform.Translate(Vector2.up * 10 * Time.deltaTime);
           temp.transform.Translate(Vector2.right * -15 * Time.deltaTime);           
           //temp.AddComponent<Rigidbody>();
           //temp.rigidbody.AddForce(fwd * 10, ForceMode.Impulse);           
           temp.SetActive(true);
       }  
    }
 
    void Update ()
    {
       if (Input.GetMouseButtonDown(0)) // 0 means left click
       {          
           Shoot();
           audio.Play();          
       }
    }
}
