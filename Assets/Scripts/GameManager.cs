using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; //���� ���� �� Ȱ��ȭ �� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; //���� �ð� ǥ��
    public Text recordText; // ���� �ð� ǥ��
    public Text coinScore; // ���� ���� ǥ��

    private float surviveTime;
    private bool isGameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        surviveTime = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
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
    }
}
