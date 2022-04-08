using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 15f;
    public int damage = 60; 
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Telling the arrow to move forward
        rb.velocity = transform.right * speed;
    
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        Debug.Log("Hit info: " + hitInfo);
        BasicEnemyController enemy = hitInfo.GetComponent<BasicEnemyController>();
        Debug.Log("Enemy: " + enemy);
        if(enemy != null) {
            
            enemy.Damage(damage);
        }
        
        /*if(hitInfo.name == "Alive"){
            //animation
            Destroy(gameObject);
        }
        */
    }

}
