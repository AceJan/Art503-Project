using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 40; 
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Telling the arrow to move forward
        rb.velocity = transform.right * speed;
        
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        Debug.Log(hitInfo);
        Enemy2 enemy = hitInfo.GetComponent<Enemy2>();
        
        if(enemy != null) {
            enemy.TakeDamage(damage);
        }
        
        if(hitInfo.name == "Square (2)"){
            //animation
            Destroy(gameObject);
        }
    }

    // Update is called once per frame

}
