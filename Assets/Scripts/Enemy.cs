using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /* public float damage = 10f;

    private void Start()
    {
        GameManager.Instance.AddObserver(PlayerDamage);
    }

    private void PlayerDamage(float damage)
    {
        Debug.Log("Enemigo reacciona al danho del jugador.");
    } */

    public float damage = 10f;
    
    [SerializeField]
    private EnemyHealthBar healthBar;

    private void Start()
    {
        healthBar = FindObjectOfType<EnemyHealthBar>();
        GameManager.Instance.AddObserver(PlayerDamage);
    }

    private void PlayerDamage(float damage)
    {
        Debug.Log("Enemigo reacciona al danho del jugador.");
        TakeDamage(damage);
    }

    private void TakeDamage(float damage)
    {
        healthBar.slider.value -= damage;

        if (healthBar.slider.value <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemigo derrotado");

        Destroy(gameObject);
    }
} 
