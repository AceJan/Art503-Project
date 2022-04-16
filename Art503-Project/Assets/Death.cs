using UnityEngine;

public class Death : MonoBehaviour
{

    [Header ("Animator")]
    [SerializeField] private Animator anim; 


    public int health = 100; 
   //public GameObject deathEffect;

   public void TakeDamage (int damage) {
       health -= damage;

       if(health <= 0) {
           Die();
       }


   }

   void Die() {
        if(GetComponentInParent<EnemyPatrol>() != null){
           GetComponentInParent<EnemyPatrol>().enabled = false;
        }
       
        if(GetComponentInParent<meleeEnemy>() != null){
           GetComponentInParent<meleeEnemy>().enabled = false;
        }

        anim.SetBool("moving", false);
        anim.SetTrigger("die");
        Destroy(gameObject);
       
   }

}
