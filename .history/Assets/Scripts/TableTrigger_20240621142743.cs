using UnityEngine;

public class TriggerColorChange : MonoBehaviour
{
    public GameObject table; 
    public Color newColor = Color.red; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SpriteRenderer tableRenderer = table.GetComponent<SpriteRenderer>();
            
            if (tableRenderer != null)
            {
                targetRenderer.color = newColor;
            }
        }
    }
}