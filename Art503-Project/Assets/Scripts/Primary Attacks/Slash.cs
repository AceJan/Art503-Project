using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider){
        Enemy2 enemy = collider.GetComponent<Enemy2>();
        if(enemy != null ) {
            enemy.TakeDamage(20);
        }

        BossScript enemyBoss = collider.GetComponent<BossScript>();
        if(enemyBoss != null){
            enemyBoss.TakeDamage(20);
        }
    }
}
