using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    private void Awake()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        
        score.text = "Punkty: "  + scoreValue;
    }
}
