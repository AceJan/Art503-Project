using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] bool isEnemy = false;
    [SerializeField] bool isPotion = false;
    [SerializeField] Transform potionCheckCollider;
    [SerializeField] LayerMask potionLayer;
    [SerializeField] float potionCheckRadius = .5f;
    [SerializeField] Transform enemyCheckCollider;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] float enemyCheckRadius = .5f;
    public float currentHealth {get; private set;}
    float timeLeft = 1;

    public static bool tankDefense = false;

    public Sprite tankDefendSprite;
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
        CheckHealthPotion();
        if(isPotion) HealPlayer(1);

        if(timeLeft <= 0) {
            Hero.spriteRenderer.color = Color.white;
            tankDefense = false;
        }
        if(Hero.heroNumber == 3 && Input.GetButtonDown("Fire1")){
            tankDefense = true;
            Hero.spriteRenderer.sprite = tankDefendSprite;
            Hero.spriteRenderer.color = Color.yellow;
            timeLeft = 1;
            timeLeft -= Time.deltaTime;
        }
        if(tankDefense){
            timeLeft -= Time.deltaTime;
        }
        //if player falls through map
        if(Hero.rb.transform.position.y <= -10){
            SceneManager.LoadScene(2);
        }
    }

    
    void CheckEnemyLayer()
    {
        isEnemy = Physics2D.OverlapCircle(enemyCheckCollider.position, enemyCheckRadius, enemyLayer);
    }

    void CheckHealthPotion()
    {
        isPotion = Physics2D.OverlapCircle(potionCheckCollider.position, potionCheckRadius, potionLayer);
    }

}
