using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float damage = 10f;
    
    public BossHealthBar healthBar;

    private void Start()
    {
        healthBar = FindObjectOfType<BossHealthBar>();
        GameManager.Instance.AddObserver(PlayerDamage);
    }

    private void PlayerDamage(float damage)
    {
        Debug.Log("Jefereacciona al danho del jugador.");
        TakeDamage(damage);
    }

    private void TakeDamage(float damage)
    {
        healthBar.slider.value -= damage;
    }
}
