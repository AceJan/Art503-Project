using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking = false;
    private float attackTimer = 0f;
    private float attackCooldown = 0.3f;
    public Collider2D attackTrigger;

    void Awake()
    {
        attackTrigger.enabled = false;
    }
    void Update()
    {
        // Placeholder for attack animations
        if(Input.GetKeyDown("z") && ! attacking){
            Debug.Log("primary attack");
            attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }
        if(Input.GetKeyDown("x")){
            Debug.Log("ultimate attack");
            attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }

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
