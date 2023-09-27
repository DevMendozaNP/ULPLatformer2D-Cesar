using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public float playerHitLevel = 15f;

    private void Start()
    {
        GameManager.Instance.AddObserver3(EnemyDamage);
        GameManager.Instance.AddObserver4(BossDamage);
    }

    private void EnemyDamage(float damage)
    {
        //Debug.Log("Están golpeando al enemigo");
    }

    private void BossDamage(float damage)
    {
        //Debug.Log("Están golpeando al jefe)";
    }
}
