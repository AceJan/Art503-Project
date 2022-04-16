using UnityEngine;

public class attackTrigger : MonoBehaviour
{
 // Ranger
    public Transform firePoint; // Position of the arrow 
    public GameObject arrowPrefab; // Arrow Prefab (Object)

    // Mage
    public Transform fireBallPoint; // Position of the fireball
    public GameObject fireBallPrefab;
    
    private bool attacking = false;
    private float attackTimer = 1f;
    private float attackCooldown = .5f;
    public Collider2D aT; //attackTrigger

    public Sprite rogueAttackSprite;
    public Sprite tankAttackSprite;
    void Start()
    {
        aT.enabled = false;
    }
    void Update () {
        if(Input.GetButtonDown("Fire1")){
            
            if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 1 && !attacking) {
                FireArrow();
            }
            else if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 2 && !attacking) {
                Slash();
            }
            else if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 4 && !attacking) {
                FireBall();
            }
        }
        if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 3 && !attacking && Hero.tankAtt) {
            Charge();
        }
        if(attacking){
            if(attackTimer > 0){
                attackTimer -= Time.deltaTime;
            } else {
                Hero.spriteRenderer.color = Color.white;
                Hero.rangerAnimator.enabled = true;
                attacking = false;
                aT.enabled = false;
            }
        }

    }

    void FireArrow () {
        // Arrows firing logic
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        attacking = true;
        attackTimer = attackCooldown;
        aT.enabled = true;
        //Debug.Log("Arrow instantiated.");
    }


    void FireBall () {
        // Mage
        Instantiate(fireBallPrefab, fireBallPoint.position, fireBallPoint.rotation);
        attacking = true;
        attackTimer = attackCooldown;
        aT.enabled = true;
    }

    void Slash() {
        // Rogue
        //Debug.Log("Slash instantiated.");
        //Debug.Log("rogue attack");
        //change sprite to attack
        Hero.rangerAnimator.enabled = false;
        Hero.spriteRenderer.sprite = rogueAttackSprite;
        attacking = true;
        attackTimer = attackCooldown/2;
        aT.enabled = true;
    }

    void Charge() {
        // Tank
        //Debug.Log("Deflect instantiated.");
        Hero.rangerAnimator.enabled = false;
        Hero.spriteRenderer.sprite = tankAttackSprite;
        Hero.spriteRenderer.color = Color.blue;
        attacking = true;
        attackTimer = attackCooldown/3;
        aT.enabled = true;
    }
}
