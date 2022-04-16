using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private bool attacking = false;
    private float attackTimer = 1f;
    private float attackCooldown = .5f;
    public Collider2D attackTrigger;

    public Sprite rogueAttackSprite;
    public Sprite rogueIdleSprite;
    void Start()
    {
        attackTrigger.enabled = false;
    }
    void Update()
    {
        // Placeholder for attack animations
        if(Input.GetKeyDown("z") && !attacking && Hero.heroNumber == 2){
            //Debug.Log("rogue attack");
            //change sprite to attack
            Hero.rangerAnimator.enabled = false;
            Hero.spriteRenderer.sprite = rogueAttackSprite;
            attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }
        if((Hero.heroNumber == 3) && !attacking && Hero.tankAtt){
            Debug.Log("tank attack");
            attacking = true;
            attackTimer = attackCooldown * 2;
            attackTrigger.enabled = true;
        }
        //cooldown timer
        if(attacking){
            if(attackTimer > 0){
                attackTimer -= Time.deltaTime;
            } else {
                Hero.rangerAnimator.enabled = true;
                Hero.spriteRenderer.sprite = rogueIdleSprite;
                attacking = false;
                attackTrigger.enabled = false;
            }
        }
    }
}
