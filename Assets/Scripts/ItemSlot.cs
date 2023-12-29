using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour
{
    public string itemName;
    public RectTransform uiElement;
    public Vector3 worldPosition;

    private void Awake()
    {
        uiElement = transform.GetComponent<RectTransform>();

        //Vector3[] corners = new Vector3[4];
        //uiElement.GetWorldCorners(corners);

        //Debug.Log("Screen point1: " + new Vector3(uiElement.rect.xMax, uiElement.rect.yMin, 0) + uiElement.position);
        //foreach (Vector3 corner in corners)
        //{
        //    Debug.Log("World point: " + corner);
        //    Debug.Log("Screen point: " + RectTransformUtility.WorldToScreenPoint(null, corner));
        //    Debug.Log("Viewport: " + Camera.main.ScreenToViewportPoint(corner));
        //}

        worldPosition = uiElement.position;
    }
}
