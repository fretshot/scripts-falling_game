using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admob_BannerView_Gameplay : MonoBehaviour
{

    // Use AdRequest.Builder.addTestDevice("7C1A3B8609D85F1DEEA618F52DD1247D") to get test ads on this device.

    private BannerView bannerView;

    public void Awake(){

        if (PlayerPrefs.HasKey("Ads")) {
            string state = PlayerPrefs.GetString("Ads");
            if (state == "True") {
                if (this.bannerView != null) {
                    this.bannerView.Destroy();
                }
            }

            if (state == "False") {
                this.RequestBanner();
            }
        } else {
            this.RequestBanner();
        }
    }

    private void RequestBanner(){

        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-5248686580922732/5331448736";
        #elif UNITY_IPHONE
                string adUnitId = "ca-app-pub-5248686580922732/5331448736";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        if (this.bannerView != null) {
            this.bannerView.Destroy();
            
        }

        // Create a  banner at the top of the screen.
        //AdSize adSize = new AdSize(468, 60);
        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice("7C1A3B8609D85F1DEEA618F52DD1247D").Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
}