using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllers : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOver()
    {
        Invoke("ShowOverPanel", 2.0f);
    }
    void ShowOverPane()
    {
        gameOverPanel.SetActive(true);
    }
}
