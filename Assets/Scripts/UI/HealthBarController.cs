using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image innerHealthBar;
    private void OnDisable()
    {
        PlayerController.damagedEvent -= UpdateHealthBar;
    }

    private void OnEnable()
    {
        PlayerController.damagedEvent += UpdateHealthBar;
    }

    private void UpdateHealthBar(float health)
    {
        innerHealthBar.fillAmount = health / PlayerController.maxHealth;
    }
}
