using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameOn : MonoBehaviour
{
    public TMP_Text Player1Name;
    public TMP_Text Player2Name;

    void Start()
    {
        // Bind the playerNames list to a UI element such as a Text or Dropdown component
        Player1Name.text = NameHandler.playerNames[0];
        Player2Name.text = NameHandler.playerNames[1];
    }
}
