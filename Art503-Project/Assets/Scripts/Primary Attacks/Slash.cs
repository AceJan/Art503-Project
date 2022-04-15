using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider){
        BossScript enemyBoss = collider.GetComponent<BossScript>();
        if(enemyBoss != null){
            enemyBoss.TakeDamage(20);
        }

        Death enemy = collider.GetComponent<Death>();
        if(enemy != null && collider.tag == "Enemy") {
            enemy.TakeDamage(20);
        }
    }
}
