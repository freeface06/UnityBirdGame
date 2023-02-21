using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    TextMeshProUGUI resourceText;
    void Start()
    {
        resourceText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        resourceText.text = "Score\n" + Score.score.ToString("F2");
    }
}
