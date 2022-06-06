using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using System;
using UnityEngine.UI;
public class Purchaser : MonoBehaviour,IStoreListener {

    IStoreController controller;
    
    string[] Products = new string[] {"remove_ads"};
    void Start()
    {
        var module = StandardPurchasingModule.Instance();
        ConfigurationBuilder builder = ConfigurationBuilder.Instance(module);
        foreach(string s in Products)
        {
            if (s.Contains("ads"))
            {
                builder.AddProduct(s, ProductType.NonConsumable);
            }
            else
            {
                builder.AddProduct(s, ProductType.Consumable);
            }
            builder.AddProduct(s,ProductType.Consumable);
        }
        UnityPurchasing.Initialize(this,builder);
    }
    public void BuyProduct(string ProductId)
    {
        Product product = controller.products.WithID(ProductId);

        if (product != null && product.availableToPurchase)
        {
            Debug.Log("Ürün satın alınıyor...");
            controller.InitiatePurchase(product);
        }
        else
        {
            Debug.Log("Ürün bulunamadı ya da satın alınabilir değil");
        }
    }
    public void OnInitialized(IStoreController controller,IExtensionProvider provider)
    {
        this.controller = controller;

        Debug.Log("Sistem Hazır.");
    }
    public void OnInitializeFailed(InitializationFailureReason reason)
    {
        Debug.Log("Yükleme Hatası: "+reason.ToString());
    }
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if (string.Equals(args.purchasedProduct.definition.id, Products[0], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("remove_ads", 1);
            GameObject.Find("ayarlar").GetComponent<ReklamRewardedVideo>().banner_kapat();
            GameObject.Find("ayarlar").GetComponent<ReklamRewardedVideo>().reklamları_kaldır_butonu.interactable = false;
        }
        return PurchaseProcessingResult.Complete;
    }

    public void OnPurchaseFailed(Product product,PurchaseFailureReason reason)
    {
        Debug.Log("Bu ürün satın alınamadı: "+product.ToString());
    }

}
