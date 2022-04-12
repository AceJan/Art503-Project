using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
   public int health = 100; 
   public bool ReaperDied = false;
   //public GameObject deathEffect;

   public void TakeDamage (int damage) {
       health -= damage;

       if(health <= 0) {
           Die();
       }


   }

   void Die() {
       //Instantiate(deathEffect, transform.position, Quaternion.identity);
       ReaperDied = true;
       Destroy(gameObject);
       
   }
}
