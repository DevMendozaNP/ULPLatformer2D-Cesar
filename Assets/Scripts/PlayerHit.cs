using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public float playerHitLevel = 15f;

    private void Start()
    {
        GameManager.Instance.AddObserver3(EnemyDamage);
    }

    private void EnemyDamage(float damage)
    {
        //Debug.Log("Están golpeando al enemigo");
    }
}
