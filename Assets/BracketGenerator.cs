using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BracketGenerator : MonoBehaviour
{
    public List<string> playerNames;

    void Start()
    {
        GenerateBracket();
    }

    void GenerateBracket()
    {
        // Shuffle the player names list to randomize the pairing
        Shuffle(playerNames);

        // Pair the players in the bracket
        for (int i = 0; i < playerNames.Count; i += 1)
        {
            string player1 = playerNames[i];
            string player2 = playerNames[i + 1];
            Debug.Log(player1 + " vs " + player2);
        }
    }

    // Fisher-Yates shuffle algorithm
    void Shuffle<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = Random.Range(i, list.Count);
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
