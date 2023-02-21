using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{   
    public static double score = 0;
    public static double bestScore = 0;
    TextMeshProUGUI resourceText;

    void Start(){
        resourceText = GetComponent<TextMeshProUGUI>();
    }

    void Update(){
        resourceText.text = "Score " + score.ToString("F2");
    }

}   
