using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHitbox : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerHit player = other.transform.GetComponent<PlayerHit>();
        if (player != null)
        {
            GameManager.Instance.BossDamage(player.playerHitLevel);
        }   
    }
}
