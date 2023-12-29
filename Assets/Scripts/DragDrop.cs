using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour
{
    //private bool isOver;
    private bool up;
    private Vector3 startPosition;
    public GameObject item;

    public bool firstTime = true;

    void Awake()
    {
        startPosition = item.transform.position;
    }

    //void OnMouseEnter()
    //{
    //    isOver = true;

    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        item.transform.position = ItemSlotManager.instance.CheckItemSlotAvailable().transform.position;
    //    }
    //}

    //void OnMouseExit()
    //{
    //    isOver = false;
    //}

    IEnumerator OnMouseDown()
    {
        if (firstTime)
        {
            firstTime = false;
            OnMouseUp();
            yield break;
        }
        up = false;
        while (up == false)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 pos = ray.origin + (ray.direction * 4.7f);
            item.transform.position = pos;
            yield return new WaitForEndOfFrame();
        }
    }

    void OnMouseUp()
    {
        up = true;
        foreach(ItemSlot slot in ItemSlotManager.instance.itemSlotList)
        {
            if(item.name == slot.itemName)
            {
                item.transform.position = slot.worldPosition;
                return;
            }
        }
        ItemSlot itemSlot = ItemSlotManager.instance.CheckItemSlotAvailable();

        item.transform.position = itemSlot.worldPosition;
        itemSlot.itemName = item.name;
        item.TryGetComponent<KeyItemScript>(out KeyItemScript a);
        if (a)
            a.isCollected = true;
        
    }

    public void Reset()
    {
        item.transform.position = startPosition;
    }

    private void OnDestroy()
    {
        foreach (ItemSlot slot in ItemSlotManager.instance.itemSlotList)
        {
            if (item.name == slot.itemName)
            {
                slot.itemName = null;
            }
        }
    }
}