using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
//using GoogleMobileAds.Api;


public class BannerAds : MonoBehaviour
{
     public string gameId = "3831705";
     public string placementId = "Banner";
     public bool testMode = false;

      IEnumerator Start()
      {
          Advertisement.Initialize(gameId, testMode);
          while (!Advertisement.IsReady(placementId))
         {
             yield return null;
         }

       Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
       Advertisement.Banner.Show(placementId);


     }

  /*private BannerView bannerView;
    
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";
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
        this.bannerView.LoadAd(request);
    }
    */
}



