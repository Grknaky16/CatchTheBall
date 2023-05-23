using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject game_manager,start_menu,gameOver;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void StartButton()
    {
        start_menu.SetActive(false);
        game_manager.SetActive(true);
    }
    public void RestartButton()
    {
        gameOver.SetActive(false);
        game_manager.SetActive(true);
    }
}
