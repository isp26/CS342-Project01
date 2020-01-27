using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUILogic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRestartButtonPressed()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Modified");
    }
}
