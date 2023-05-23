using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdScript : MonoBehaviour
{
    public static AdScript Instance;
    private InterstitialAd interstitial_Ad;
    private RewardedAd rewardedAd;
    public bool endgame = false;

    public int Puan = 0;
    public int Coin = 0;

    private string interstitial_Ad_ID;
    private string rewardedAd_ID;
   
    void Start()
    {
        interstitial_Ad_ID = "ca-app-pub-3940256099942544/1033173712";
        rewardedAd_ID = "ca-app-pub-3940256099942544/5224354917";

        MobileAds.Initialize(initStatus => { });

        RequestInterstitial();
        RequestRewardedVideo();
    }
    
    private void RequestInterstitial()
    {
        interstitial_Ad = new InterstitialAd(interstitial_Ad_ID);
        interstitial_Ad.OnAdLoaded += HandleOnAnLoaded;
        AdRequest request = new AdRequest.Builder().Build();
        interstitial_Ad.LoadAd(request);
    }

    private void RequestRewardedVideo()
    {
        rewardedAd = new RewardedAd(rewardedAd_ID);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }

    public void ShowInterstitial()
    {
        if (interstitial_Ad.IsLoaded())
        {
            interstitial_Ad.Show();
            RequestInterstitial();

        }
    }

    public void ShowRewardedVideo()
    {
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            if (endgame == false)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Puan = PlayerPrefs.GetInt("Puan");
                Coin = PlayerPrefs.GetInt("catchtheball");
                Puan += Coin;
                PlayerPrefs.DeleteKey("catchtheball");
                PlayerPrefs.SetInt("Puan", Puan);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
    }

    public void HandleOnAnLoaded(object sender, EventArgs args)
    {

    }
    public void HandleRewardedAdFailedToShow(object sender, EventArgs args)
    {
        RequestRewardedVideo();
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HandleUserEarnedReward(object sender, EventArgs args)
    {
        RequestRewardedVideo();
    }



}
