using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomObjectScript : MonoBehaviour
{
    private void Awake()
    {
        TravelManager.shopScene = true;
        TravelManager.ikeaScene = true;
        TravelManager.bakeryScene = true;
        //TravelManager.blackMarketScene = true;
        //TravelManager.flowerShopScene = true;
        TravelManager.workPlaceScene = true;
    }
}
