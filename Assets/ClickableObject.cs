using UnityEngine;
using PixelCrushers.DialogueSystem;

public class ClickableObject : MonoBehaviour
{
    private void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in the world coordinates
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Perform a raycast to check for objects at the mouse position
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // If an object is hit, do something
            if (hit.collider != null)
            {
                // Replace this with your desired logic when an object is clicked
                if (hit.collider.gameObject.name != "Wife")
                    return;
                else
                    transform.GetComponent<DialogueSystemTrigger>().enabled = true;
            }
        }
    }
}
