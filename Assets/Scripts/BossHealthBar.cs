using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Start()
    {
        // Registro como Observer
        GameManager.Instance.AddObserver4(BossDamage);
    }

    private void BossDamage(float playerHitLevel)
    {
        slider.value -= playerHitLevel;
    }

}
