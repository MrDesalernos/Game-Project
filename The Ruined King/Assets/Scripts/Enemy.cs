using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public  Animator animator;
    bool death = false;
    public int maxHealth = 100;
    int currentHealth;
    public AudioSource source;
    public AudioClip clip, deathSoundEffect;
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
        if (death == false)
        {
            animator.SetTrigger("Hurt");
            source.PlayOneShot(clip);
        }
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (death == false)
        {
            ScoreManager.instance.AddPoint();
            source.PlayOneShot(deathSoundEffect);
        }
        death = true;
        animator.SetBool("IsDead", true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = true;
        Debug.Log("Enemy Died!");
        Destroy(gameObject, 1.2f);
    }
}
