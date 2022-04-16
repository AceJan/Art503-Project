using UnityEngine;

public class ProjectileU : MonoBehaviour
{
    public Rigidbody2D rb;
    string brick = "AssetBrickPlatform";
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0,1);
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        if(hitInfo.tag == "Player" && !Health.tankDefense){
            GameObject.Find("Player").GetComponent<Health>().TakeDamage(1);
            Destroy(gameObject);
        }
        if(hitInfo.name.Contains(brick)){
            //animation
            Destroy(gameObject);
        }
    }
}
