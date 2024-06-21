using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variables to adjust speed in the inspector
    public float moveSpeed = 5f;

    // Private variables for input and Rigidbody2D
    private Vector2 movement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the horizontal and vertical axes
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Set the movement vector based on input
        movement = new Vector2(moveX, moveY);
    }

    // FixedUpdate is called at a fixed interval and is used for physics calculations
    void FixedUpdate()
    {
        // Move the player based on the movement vector and speed
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}