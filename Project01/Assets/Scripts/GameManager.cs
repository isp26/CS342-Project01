﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
        gameOverUI.SetActive(true);
    }
}
