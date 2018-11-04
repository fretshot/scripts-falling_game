using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admob_Inicializate : MonoBehaviour {

    public void Awake(){

        #if UNITY_ANDROID
                string appId = "ca-app-pub-5248686580922732~5714592117";
        #elif UNITY_IPHONE
                    string appId = "ca-app-pub-5248686580922732~5714592117";
        #else
                    string appId = "unexpected_platform";
        #endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
    }
}