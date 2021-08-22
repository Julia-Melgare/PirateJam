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
        PlayerController.onEndLevel -= CheckWin;
    }

    private void OnEnable()
    {
        PlayerController.damagedEvent += PlayerDamaged;
        PlayerController.onEndLevel += CheckWin;
    }

    private void PlayerDamaged(float currentHealth)
    {
        if(currentHealth <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    private void CheckWin(bool win)
    {
        if (win)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
}
