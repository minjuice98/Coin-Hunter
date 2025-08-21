using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; //게임 오버 시 활성화 할 텍스트 게임 오브젝트
    public Text coinCountText;
    public Text timeText; //생존 시간 표시
    public Text coinScoreText; // 코인 점수 표시
    public Text finalScoreText;

    public int coinCount;
    private int coinScore;
    private float surviveTime; 
    private bool isGameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        surviveTime = 0;
        coinCount = 0;
        coinScore = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
            coinCountText.text = "Coin: " + (int)coinCount;
            coinScore = coinCount * 100;
            coinScoreText.text="Score: "+ coinScore;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        
    }

    public void EndGame()
    {
        isGameOver = true;
        gameoverText.SetActive(true);
        finalScoreText.text = "Final Score: " + coinScore;
    }
}
