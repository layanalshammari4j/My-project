using UnityEngine;

public class bulletmovement : MonoBehaviour
{
   
    [SerializeField] private float speed = 10f; // Bullet speed

    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        // Get the Rigidbody 2D attached to the bullet
        rb = GetComponent<Rigidbody2D>();
    }

    // Called right after the bullet is created, to set its direction
    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void FixedUpdate()
    {
        // Move the bullet using Rigidbody 2D, same approach as player and enemy
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }

    // Called automatically by Unity when this Trigger touches another Collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        return;
        // Destroy the bullet whenever it touches anything
        Destroy(gameObject);
    }
}