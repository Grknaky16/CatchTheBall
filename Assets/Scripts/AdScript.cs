using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdScript : MonoBehaviour
{
    //public static adscript �nstance;
    //private �nterstitialad interstitial_ad;
    //private rewardedad rewardedad;
    //public bool endgame = false;

    //public int puan = 0;
    //public int coin = 0;

    //private string interstitial_ad_�d;
    //private string rewardedad_�d;

    //void start()
    //{
    //    interstitial_ad_�d = "ca-app-pub-3940256099942544/1033173712";
    //    rewardedad_�d = "ca-app-pub-3940256099942544/5224354917";

    //    mobileads.�nitialize(initstatus => { });

    //    request�nterstitial();
    //    requestrewardedvideo();
    //}

    //private void request�nterstitial()
    //{
    //    interstitial_ad = new �nterstitialad(interstitial_ad_�d);
    //    interstitial_ad.onadloaded += handleonanloaded;
    //    adrequest request = new adrequest.builder().build();
    //    interstitial_ad.loadad(request);
    //}

    //private void requestrewardedvideo()
    //{
    //    rewardedad = new rewardedad(rewardedad_�d);
    //    rewardedad.onuserearnedreward += handleuserearnedreward;
    //    rewardedad.onadclosed += handlerewardedadclosed;
    //    rewardedad.onadfailedtoshow += handlerewardedadfailedtoshow;
    //    adrequest request = new adrequest.builder().build();
    //    rewardedad.loadad(request);
    //}

    //public void show�nterstitial()
    //{
    //    if (interstitial_ad.�sloaded())
    //    {
    //        interstitial_ad.show();
    //        request�nterstitial();

    //    }
    //}

    //public void showrewardedvideo()
    //{
    //    if (rewardedad.�sloaded())
    //    {
    //        rewardedad.show();
    //        if (endgame == false)
    //        {
    //            //scenemanager.loadscene(scenemanager.getactivescene().build�ndex + 1);
    //            puan = playerprefs.get�nt("puan");
    //            coin = playerprefs.get�nt("catchtheball");
    //            puan += coin;
    //            playerprefs.deletekey("catchtheball");
    //            playerprefs.set�nt("puan", puan);
    //        }
    //        else
    //        {
    //            scenemanager.loadscene(scenemanager.getactivescene().build�ndex);
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
    //    scenemanager.loadscene(scenemanager.getactivescene().build�ndex + 1);
    //}

    //public void handleuserearnedreward(object sender, eventargs args)
    //{
    //    requestrewardedvideo();
    //}



}
