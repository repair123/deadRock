﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text ScoreUI;
    public Text LifeUI;

    int coinCount, lifeCount;

    [SerializeField] GameObject go_ClearUI;
    [SerializeField] GameObject go_DeathUI;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        else
        {
            Debug.Log("씬에 두 개 이상의 게임매니저가 존재");
            Destroy(gameObject);
        }
        
        coinCount = 0;
        lifeCount = 5;
        LifeUI.text = "Life : " + lifeCount;
    }

    public void GetLife()
    {
        lifeCount--;
        LifeUI.text = "Life : " + lifeCount;
    }

    public void GetScore()
    {
        coinCount++;
        ScoreUI.text = "Score : " + coinCount;
    }

    public void ShowClearUI()
    {
        go_ClearUI.SetActive(true);
    }

    public void ShowDeathUI()
    {
        go_DeathUI.SetActive(true);
    }

    public void ReStartGame()
    {
        Application.LoadLevel("test");
    }

    public void NextStage()
    {
        Debug.Log("다음 스테이지");
    }

    public void Exit()
    {
        Debug.Log("게임 종료");
    }
}
