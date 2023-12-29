using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TravelManager : MonoBehaviour
{
    public static TravelManager instance;
    public static bool shopScene;
    public static bool ikeaScene;
    public static bool bakeryScene;
    public static bool homeScene;
    //public static bool flowerShopScene;
    //public static bool blackMarketScene;
    public static bool workPlaceScene;
    public static bool closet;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void SetActiveShopScene()
    {
        shopScene = true;
    }

    public void TravelToShop()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        PixelCrushers.SaveSystem.LoadScene("ShopScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();
    }
    public void TravelToIkea()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        PixelCrushers.SaveSystem.LoadScene("IkeaScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }
    public void TravelToBakery()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("BakeryScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }
    public void TravelToHome()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("HomeScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }
    public void TravelToFlowerShop()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("FlowerShopScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }
    public void TravelToBlackMarket()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("BlackMarketScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }
    public void TravelToWorkPlace()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("WorkPlaceScene");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }

    public void TravelToTravelMap()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("TravelMap");
        PixelCrushers.SaveSystem.ApplySavedGameData();

    }

    public void TravelToCloset()
    {
        PixelCrushers.SaveSystem.BeforeSceneChange();
        PixelCrushers.SaveSystem.RecordSavedGameData();
        
        PixelCrushers.SaveSystem.LoadScene("Closet");
        PixelCrushers.SaveSystem.ApplySavedGameData();
    }
}
