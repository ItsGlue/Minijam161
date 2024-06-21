using UnityEngine;

public class TriggerColorChange : MonoBehaviour
{
    public GameObject targetObject; 
    public Color newColor = Color.red; // The color to change to

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the trigger zone
        if (other.CompareTag("Player"))
        {
            // Get the SpriteRenderer component of the target object
            SpriteRenderer targetRenderer = targetObject.GetComponent<SpriteRenderer>();
            
            if (targetRenderer != null)
            {
                // Change the color of the target object
                targetRenderer.color = newColor;
            }
        }
    }
}