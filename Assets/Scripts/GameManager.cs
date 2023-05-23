using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour
{
    public GameObject Ball_prefab;
    public PotaRotator pota_rotator;
    public Text text;
    public Text puan;
    public static int Puan;
    public int Coin;
    public PotaRotator catchtheball;
    


    
    void Start()
    {
        Time.timeScale=1;
        InvokeRepeating("SpawnBall",1,1);
    }


    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName == "Level_1" || sceneName =="Level_2" ||sceneName =="Level_3" ||sceneName =="Level_4" ||sceneName =="Level_5" ||sceneName =="Level_6" ||sceneName =="Level_7" ||sceneName =="Level_8" ||sceneName =="Level_9")
        {
            text.text = pota_rotator.catchtheball.ToString();
            puan.text=PlayerPrefs.GetInt("Puan")+"";
        }
}
    
    void SpawnBall(){
        float tempPos= Random.Range(-2.31f, 2.31f);
        Instantiate(Ball_prefab, new Vector3(tempPos,6f,0),Quaternion.identity);
    }
    public void StopSpawning(){
        CancelInvoke();
    }

    public void NextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Menu()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(0);
        
    } 
    
    public void RestartGame(){
        //RewardedAdsButton.Instance.endgame = true;
        //RewardedAdsButton.Instance.ShowAd();
        AdScript.Instance.endgame = true;
        AdScript.Instance.ShowRewardedVideo();
    }
    public void NextLevel2x()
    {
        //RewardedAdsButton.Instance.endgame = false;
        //RewardedAdsButton.Instance.ShowAd();
        AdScript.Instance.endgame = false;
        AdScript.Instance.ShowRewardedVideo();
        
    }
}
