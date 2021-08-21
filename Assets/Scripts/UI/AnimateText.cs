using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimateText : MonoBehaviour
{
    [SerializeField]
    TMP_Text playText;
    [SerializeField]
    TMP_Text instructionsText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickPlayText()
    {
        playText.color = Color.grey;
        playText.alignment = TextAlignmentOptions.Top;
    }

    public void ClickInstructionsText()
    {
        instructionsText.color = Color.grey;
        instructionsText.alignment = TextAlignmentOptions.Bottom;
    }
}
