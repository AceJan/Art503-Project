using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth {get; private set;}

    private void Start()
    {
        currentHealth = startingHealth;
        Debug.Log(currentHealth);
    }
    public void TakeDamage(float dmg)
    {
        currentHealth = Mathf.Clamp(currentHealth -= dmg, 0, startingHealth);
        
        if(currentHealth > 0){
            //player is alive
        } else {
            //player is dead
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
            TakeDamage(1);
    }

}