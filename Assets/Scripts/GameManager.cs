using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance;

    public UnityAction<float> OnPlayerDamage;
    public UnityAction<float> OnPlayerPower;
    public UnityAction<float> OnEnemyDamage;
    public UnityAction<float> OnBossDamage;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayerDamage(float damage)
    {
        // Notificar a todos que el jugador recibió un danho
        OnPlayerDamage.Invoke(damage);
    }

    public void PlayerPower(float power)
    {
        //Notificar a todos cuanto poder tiene el jugador
        OnPlayerPower.Invoke(power);
    }

    public void EnemyDamage(float playerHitLevel)
    {
        //Notificar a los enemigos cuanto daño reciben
        OnEnemyDamage.Invoke(playerHitLevel);
    }

    public void BossDamage(float playerHitLevel)
    {
        //Notificar al jefe cuanto daño recibe
        OnEnemyDamage.Invoke(playerHitLevel);
    }

    public void AddObserver(UnityAction <float> action)
    {
        OnPlayerDamage += action;
    }

    public void AddObserver2(UnityAction <float> action)
    {
        OnPlayerPower += action;
    }

    public void AddObserver3(UnityAction <float> action)
    {
        OnEnemyDamage += action;
    }

    public void AddObserver4(UnityAction <float> action)
    {
        OnBossDamage += action;
    }
}
