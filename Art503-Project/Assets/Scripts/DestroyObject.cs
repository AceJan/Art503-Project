using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Heal") {
            Destroy(gameObject);
        }
    }
    
}
