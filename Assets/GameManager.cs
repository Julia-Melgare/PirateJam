using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private PlayerController _player;


    private void OnDisable()
    {
        PlayerController.damagedEvent -= PlayerDamaged;
    }

    private void OnEnable()
    {
        PlayerController.damagedEvent += PlayerDamaged;
    }

    private void PlayerDamaged(float currentHealth)
    {
        if(currentHealth <= 0)
        {
            //GAME OVER
            
        }
    }
}
