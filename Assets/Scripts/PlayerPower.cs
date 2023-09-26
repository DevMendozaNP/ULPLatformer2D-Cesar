using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{
    //Identificar si el jugador golpeó al rival por arriba
    private void OnCollisionEnter2D(Collision2D other)
    {
        EnemyPower enemyPower = other.transform.GetComponent<EnemyPower>();
        if (enemyPower != null)
        {
             GameManager.Instance.PlayerPower(enemyPower.power);
        }
    }
}
