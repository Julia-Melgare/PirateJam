using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstructionsController : MonoBehaviour
{
    [SerializeField]
    GameObject instructionsPanel;
    [SerializeField]
    TMP_Text instructionsText;

    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true);
    }

    public void HideInstructions()
    {
        instructionsText.color = Color.white;
        instructionsText.alignment = TextAlignmentOptions.Center;
        instructionsPanel.SetActive(false);
    }
}
