using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{

    public Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Start()
    {
        // Registro como Observer
        GameManager.Instance.AddObserver3(EnemyDamage);
    }

    private void EnemyDamage(float playerHitLevel)
    {
        slider.value -= playerHitLevel;
    }

}
