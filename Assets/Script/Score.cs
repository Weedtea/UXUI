using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public bool isHighScore;

    float highScore;
    Text uiText;

    //점수 구현
    void Start()
    {
        uiText = GetComponent<Text>();

        if(isHighScore) {
            highScore = PlayerPrefs.GetFloat("Score");
            uiText.text = highScore.ToString("F0");
        }
    }

    //최고점수
    void LateUpdate()
    {
        if (isHighScore && GameManager.score < highScore)
            return;
        uiText.text = GameManager.score.ToString("F0");

    }
}
