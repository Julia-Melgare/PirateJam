using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinUIScript : MonoBehaviour
{
    [SerializeField]
    GameObject winCanvas;

    private void OnDisable()
    {
        PlayerController.onEndLevel -= CheckWin;
    }

    private void OnEnable()
    {
        PlayerController.onEndLevel += CheckWin;
    }
 
    private void CheckWin(bool win)
    {
        if (win)
            winCanvas.SetActive(true);
        else
            winCanvas.SetActive(false);
    }
}
