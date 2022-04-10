using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] bool isEnemy = false;
    [SerializeField] Transform enemyCheckCollider;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] float enemyCheckRadius = .5f;
    public float currentHealth {get; private set;}
    float timeLeft = 1;


    private void Start()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float dmg)
    {
        currentHealth = Mathf.Clamp(currentHealth -= dmg, 0, startingHealth);
        
        if(currentHealth > 0){
            //player is alive
        } else {
            //player is dead
            SceneManager.LoadScene(2);
        }
    }

    public void HealPlayer(float dmg)
    {
        currentHealth = Mathf.Clamp(currentHealth += dmg, 0, startingHealth);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) 
            TakeDamage(1);
        if(Input.GetKeyDown(KeyCode.E))
            HealPlayer(1);
        CheckEnemyLayer();

        if(isEnemy){
            if(timeLeft == 1) TakeDamage(1);
            timeLeft -= Time.deltaTime;
            if(timeLeft < 0) timeLeft = 1;
            
        }
        if(!isEnemy){
            timeLeft = 1;
        }
        if(Hero.rb.transform.position.y <= -10){
            SceneManager.LoadScene(2);
        }
    }

    
    void CheckEnemyLayer()
    {
        isEnemy = Physics2D.OverlapCircle(enemyCheckCollider.position, enemyCheckRadius, enemyLayer);
    }
}
