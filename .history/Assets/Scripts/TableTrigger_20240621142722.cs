using UnityEngine;

public class TriggerColorChange : MonoBehaviour
{
    public GameObject table; 
    public Color newColor = Color.red; 

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the trigger zone
        if (other.CompareTag("Player"))
        {
            SpriteRenderer targetRenderer = table.GetComponent<SpriteRenderer>();
            
            if (targetRenderer != null)
            {
                // Change the color of the target object
                targetRenderer.color = newColor;
            }
        }
    }
}