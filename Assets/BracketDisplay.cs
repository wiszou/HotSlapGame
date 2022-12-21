using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BracketDisplay : MonoBehaviour
{
    public TMP_Text bracketText;
    public BracketGenerator bracketGenerator;

    void Start()
    {
        UpdateBracket();
    }

    void UpdateBracket()
    {
        string bracketString = "";
        for (int i = 0; i < bracketGenerator.playerNames.Count; i += 2)
        {
            string player1 = bracketGenerator.playerNames[i];
            string player2 = bracketGenerator.playerNames[i + 1];
            bracketString += player1 + " vs " + player2 + "\n";
        }
        bracketText.text = bracketString;
    }
}
