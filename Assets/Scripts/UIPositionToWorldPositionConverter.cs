using UnityEngine;

public class UIPositionToWorldPositionConverter : MonoBehaviour
{
    [SerializeField] private RectTransform uiElement;

    // Update is called once per frame
    void Update()
    {
        // Get mouse position in screen coordinates
        Vector2 screenPosition = Input.mousePosition;

        // Convert screen position to world position
        Vector3 worldPosition;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(uiElement, screenPosition, Camera.main, out worldPosition);

        // Output the world position
        Debug.Log("World Position: " + worldPosition);
    }
}
