using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdScript : MonoBehaviour
{
    //public static adscript ýnstance;
    //private ýnterstitialad interstitial_ad;
    //private rewardedad rewardedad;
    //public bool endgame = false;

    //public int puan = 0;
    //public int coin = 0;

    //private string interstitial_ad_ýd;
    //private string rewardedad_ýd;

    //void start()
    //{
    //    interstitial_ad_ýd = "ca-app-pub-3940256099942544/1033173712";
    //    rewardedad_ýd = "ca-app-pub-3940256099942544/5224354917";

    //    mobileads.ýnitialize(initstatus => { });

    //    requestýnterstitial();
    //    requestrewardedvideo();
    //}

    //private void requestýnterstitial()
    //{
    //    interstitial_ad = new ýnterstitialad(interstitial_ad_ýd);
    //    interstitial_ad.onadloaded += handleonanloaded;
    //    adrequest request = new adrequest.builder().build();
    //    interstitial_ad.loadad(request);
    //}

    //private void requestrewardedvideo()
    //{
    //    rewardedad = new rewardedad(rewardedad_ýd);
    //    rewardedad.onuserearnedreward += handleuserearnedreward;
    //    rewardedad.onadclosed += handlerewardedadclosed;
    //    rewardedad.onadfailedtoshow += handlerewardedadfailedtoshow;
    //    adrequest request = new adrequest.builder().build();
    //    rewardedad.loadad(request);
    //}

    //public void showýnterstitial()
    //{
    //    if (interstitial_ad.ýsloaded())
    //    {
    //        interstitial_ad.show();
    //        requestýnterstitial();

    //    }
    //}

    //public void showrewardedvideo()
    //{
    //    if (rewardedad.ýsloaded())
    //    {
    //        rewardedad.show();
    //        if (endgame == false)
    //        {
    //            //scenemanager.loadscene(scenemanager.getactivescene().buildýndex + 1);
    //            puan = playerprefs.getýnt("puan");
    //            coin = playerprefs.getýnt("catchtheball");
    //            puan += coin;
    //            playerprefs.deletekey("catchtheball");
    //            playerprefs.setýnt("puan", puan);
    //        }
    //        else
    //        {
    //            scenemanager.loadscene(scenemanager.getactivescene().buildýndex);
    //        }

    //    }
    //}

    //public void handleonanloaded(object sender, eventargs args)
    //{

    //}
    //public void handlerewardedadfailedtoshow(object sender, eventargs args)
    //{
    //    requestrewardedvideo();
    //}

    //public void handlerewardedadclosed(object sender, eventargs args)
    //{
    //    scenemanager.loadscene(scenemanager.getactivescene().buildýndex + 1);
    //}

    //public void handleuserearnedreward(object sender, eventargs args)
    //{
    //    requestrewardedvideo();
    //}



}
