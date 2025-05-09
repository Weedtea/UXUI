using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    const float ORIGIN_SPEED = 1;

    public static float globalSpeed;
    public static float score;
    public static bool isLive;
    public GameObject uiOver;

    //���� Ȯ��
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Score"))
            PlayerPrefs.SetFloat("Score", 0);
    }
    void Start()
    {
        isLive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isLive) {
            score += Time.deltaTime;
            globalSpeed = ORIGIN_SPEED + score * 0.01f;
        }

     
    }
    //���� ����
    public void GameOver() {
        uiOver.SetActive(true);
        isLive = false;

        float highScore = PlayerPrefs.GetFloat("Score");
        PlayerPrefs.SetFloat("Score", Mathf.Max(highScore, score));
    }
    //����� ��ư ���
    public void Restart()
    {
        SceneManager.LoadScene(0);
        score = 0;
        isLive = true;

    }
}

