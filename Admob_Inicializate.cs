using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admob_Inicializate : MonoBehaviour {

    public void Start(){

        #if UNITY_ANDROID
                string appId = "ca-app-pub-3940256099942544~3347511713";
        #elif UNITY_IPHONE
                    string appId = "ca-app-pub-3940256099942544~1458002511";
        #else
                    string appId = "unexpected_platform";
        #endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
    }
}