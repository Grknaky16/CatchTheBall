using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameManager game_manager;
    public GameObject MenuBar,Options;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void RestartGame(){
        SceneManager.LoadScene(1);
    }

    public void Optionss()
    {
        Time.timeScale = 0;
        MenuBar.SetActive(false);
        Options.SetActive(true);
    }

    public void Quit() {
    #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
}
}
