using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotManager : MonoBehaviour
{
    public static ItemSlotManager instance;
    public List<ItemSlot> itemSlotList;
    public GameObject itemSlotPrefab;

    private void Awake()
    {
        instance = this;
    }

    public ItemSlot CheckItemSlotAvailable()
    {
        for (int i = 0; i < itemSlotList.Count; i++)
        {
            if(itemSlotList[i].itemName == "")
            {
                return itemSlotList[i];
            }
        }
        GameObject newItemSlot = Instantiate(itemSlotPrefab, new Vector3 (itemSlotList[itemSlotList.Count].transform.position.x, itemSlotList[itemSlotList.Count].transform.position.y + 150, itemSlotList[itemSlotList.Count].transform.position.z), Quaternion.identity);
        itemSlotList.Add(newItemSlot.GetComponent<ItemSlot>());
        return newItemSlot.GetComponent<ItemSlot>();
    }
}
