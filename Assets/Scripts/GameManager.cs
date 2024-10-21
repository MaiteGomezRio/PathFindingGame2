using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data;
using Mono.Data.Sqlite;
using System.Data.Common;
using System.Drawing;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int FPS = 60;
    private bool startSceneLoaded = false;
    public Button confirmButton;
    public TMP_Text input;

    void Start()
    {
        DontDestroyOnLoad(this);
        Application.targetFrameRate = FPS;
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "StartScene" && !startSceneLoaded)
        {
            confirmButton.onClick.AddListener(OnConfirmButtonClick);
            startSceneLoaded = true;
        }
        else if (currentScene.name == "StartScene")
        {
            confirmButton.onClick.AddListener(OnConfirmButtonClick);
        }
    }

    public void OnConfirmButtonClick()
    {
        string namePlayer = input.text;
        if (string.IsNullOrEmpty(namePlayer))
        {
            return;
        }
        else
        {
            SceneManager.LoadScene("MainScene");
            Debug.Log("Estamos en MainScene");
        }
    }
}
