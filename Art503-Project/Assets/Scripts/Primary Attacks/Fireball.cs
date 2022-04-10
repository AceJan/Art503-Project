using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 15f;
    public int damage = 60; 
    public Rigidbody2D rb;

    string brick = "AssetBrickPlatform";
    // Start is called before the first frame update
    void Start()
    {
        // Telling the arrow to move forward
        rb.velocity = transform.right * speed;
    
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        Enemy2 enemy = hitInfo.GetComponent<Enemy2>();
        if(enemy != null) {
            
            enemy.TakeDamage(damage);
        }
        
        //arrow will be destroyed when hitting enemy or wall
        if(hitInfo.name.Contains(brick) || hitInfo.name.Contains("Enemy2")){
            //animation
            Destroy(gameObject);
        }
    }

}
