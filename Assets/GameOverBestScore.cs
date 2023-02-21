using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverBestScore : MonoBehaviour
{
    TextMeshProUGUI resourceText;
    void Start()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        resourceText.text = "BestScore\n" + Score.bestScore.ToString("F2");
    }
}
