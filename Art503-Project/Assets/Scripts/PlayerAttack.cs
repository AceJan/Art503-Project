using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking = false;
    private float attackTimer = 1f;
    private float attackCooldown = .1f;
    public Collider2D attackTrigger;

    void Start()
    {
        attackTrigger.enabled = false;
    }
    void Update()
    {
        // Placeholder for attack animations
        if(Input.GetKeyDown("z") && !attacking && Hero.heroNumber == 2){
            Debug.Log("rogue attack");
            attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }
        if((Hero.heroNumber == 3) && !attacking && Hero.tankAtt){
            Debug.Log("tank attack");
            attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }
        //cooldown timer
        if(attacking){
            if(attackTimer > 0){
                attackTimer -= Time.deltaTime;
            } else {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
    }
}
