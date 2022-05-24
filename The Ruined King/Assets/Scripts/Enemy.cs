using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public  Animator animator;

    public int maxHealth = 100;
    int currentHealth;
    void Start()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("IsDead", true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = true;
        Debug.Log("Enemy Died!");
        Destroy(gameObject, 1.2f);
    }
}
