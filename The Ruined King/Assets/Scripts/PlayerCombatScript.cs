using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = .5f;
    public LayerMask enemyLayers;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    public int attackDamage = 40;
    bool hit = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
                
                if (hit == true)
                {
                    source.PlayOneShot(clip);
                }
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies =Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            hit = false;
        }
        hit = true;
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
