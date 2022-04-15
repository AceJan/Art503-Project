using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackTrigger : MonoBehaviour
{
 // Ranger
    public Transform firePoint; // Position of the arrow 
    public GameObject arrowPrefab; // Arrow Prefab (Object)

    // Mage
    public Transform fireBallPoint; // Position of the fireball
    public GameObject fireBallPrefab;

    void Update () {
        if(Input.GetButtonDown("Fire1")){
            
            if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 1) {
                FireArrow();
            }
            else if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 2) {
                Slash();
            }
            else if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 3) {
                Deflect();
            }
            else if(GameObject.Find("Player").GetComponent<Hero>().getHeroNumber() == 4) {
                FireBall();
            }
        }
    }

    void FireArrow () {
        // Arrows firing logic
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        //Debug.Log("Arrow instantiated.");
    }


    void FireBall () {
        // Mage
        Instantiate(fireBallPrefab, fireBallPoint.position, fireBallPoint.rotation);
        Debug.Log("Fireball instantiated.");
    }

    void Slash() {
        // Rogue
        //Debug.Log("Slash instantiated.");
    }

    void Deflect() {
        // Tank
        //Debug.Log("Deflect instantiated.");
    }
}
