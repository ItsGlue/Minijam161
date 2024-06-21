using UnityEngine;

public class TableTrigger : MonoBehaviour
{
    public GameObject table; 
    public Color newColor = Color.red; 
    private Color originalColor; // To store the original color of the table

    void Start()
    {
        // Store the original color of the table at the start
        SpriteRenderer tableRenderer = table.GetComponent<SpriteRenderer>();
        if (tableRenderer != null)
        {
            originalColor = tableRenderer.color;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SpriteRenderer tableRenderer = table.GetComponent<SpriteRenderer>();
            
            if (tableRenderer != null)
            {
                tableRenderer.color = newColor;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SpriteRenderer tableRenderer = table.GetComponent<SpriteRenderer>();
            
            if (tableRenderer != null)
            {
                tableRenderer.color = originalColor;
            }
        }
    }
}
