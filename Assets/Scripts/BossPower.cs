using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPower : MonoBehaviour
{
    public float power = 15f;
    //Cuanto se llenará la barra de poder
    //del jugador con cada golpe

    private void Start()
    {
        GameManager.Instance.AddObserver2(PlayerPower);
    }

    private void PlayerPower(float power)
    {
        Debug.Log("Lo está golpeando.");
    }
}
