using UnityEngine;

public class monster : MonoBehaviour
{

    [SerializeField] private float speed = 3f; // Enemy movement speed
    [SerializeField] private Transform player; // Reference to the player

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Calculate direction from enemy to player
        Vector2 direction = (player.position - transform.position).normalized;

        // Move enemy towards the player
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}