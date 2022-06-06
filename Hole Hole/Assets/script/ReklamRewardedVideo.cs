using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class ReklamRewardedVideo : MonoBehaviour
{
    private BannerView reklamObjesi_banner;
    public Button reklamları_kaldır_butonu;
    void OnDestroy()
    {
        if (reklamObjesi_banner != null)
            reklamObjesi_banner.Destroy();
    }

    public void banner_kapat()
    {
        reklamObjesi_banner.Hide();
    }

    public void banner_ac()
    {
        if (reklamObjesi_banner != null)
        {
            reklamObjesi_banner.Show();
        }
        else
        {
            reklamObjesi_banner = new BannerView("ca-app-pub-7140719078012798/2929141436", new AdSize(AdSize.FullWidth, 60), AdPosition.Bottom); //  test "ca-app-pub-3940256099942544/6300978111" hakanınnn ca-app-pub-7140719078012798/9291557817
            AdRequest reklamIstegi = new AdRequest.Builder().Build();
            reklamObjesi_banner.LoadAd(reklamIstegi);
        }
    }
    /// ////////////////////////////////////////////////
    void Start()
    {
        MobileAds.Initialize(reklamDurumu => { });
        if (PlayerPrefs.GetInt("remove_ads") == 0)
        {
            banner_ac();
            reklamları_kaldır_butonu.interactable = true;
        }
        else
        {
            reklamları_kaldır_butonu.interactable = false;
        }
    }
}
