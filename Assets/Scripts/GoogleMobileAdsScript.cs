using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleMobileAdsScript : MonoBehaviour
{
    private BannerView bannerView;

    // Start is called before the first frame update
    void Start()
    {

        // Initialize the Google Mobile Ads SDK.

        Invoke("startGoogleAds", 60);

        

    }

   
    private void startGoogleAds()
    {
        Debug.Log("starting ads");
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
    }
    
    private void RequestBanner()
    {

        // Live Banner ID ca-app-pub-5267937863402323/5290723690
        // Test Banner ID ca-app-pub-3940256099942544/6300978111
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-5267937863402323/5290723690";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        Debug.Log("Loading Banner");
        this.bannerView.LoadAd(request);
    }

}
