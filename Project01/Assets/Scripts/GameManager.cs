using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    AudioSource audioSource;

    public static GameManager gameManager;

    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = this;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        audioSource.Play();
        Time.timeScale = 0.0f;
        gameOverUI.SetActive(true);
    }
}
