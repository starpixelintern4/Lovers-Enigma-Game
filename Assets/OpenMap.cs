using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMap : MonoBehaviour
{
    public GameObject workPlaceScene;
    public GameObject shopScene;
    public GameObject ikeaScene;
    public GameObject bakeryScene;
    public GameObject flowerShopScene;
    public GameObject blackMarketScene;
    private void Update()
    {
        if (TravelManager.workPlaceScene)
        {
            workPlaceScene.SetActive(true);
        }
        if (TravelManager.shopScene)
        {
            shopScene.SetActive(true);
        }
        if (TravelManager.ikeaScene)
        {
            ikeaScene.SetActive(true);
        }
        if (TravelManager.bakeryScene)
        {
            bakeryScene.SetActive(true);
        }
        //if (TravelManager.flowerShopScene)
        //{
        //    flowerShopScene.SetActive(true);
        //}
        //if (TravelManager.blackMarketScene)
        //{
        //    blackMarketScene.SetActive(true);
        //}
    }
}
