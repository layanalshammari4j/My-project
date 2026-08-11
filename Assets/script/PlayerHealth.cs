using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 3;

    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    void Start()
    {
        // Get the Sprite Renderer so we can change the player's color
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        // Play the red flash effect whenever the player takes damage
        StartCoroutine(FlashRed());

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Coroutine: waits without freezing the rest of the game
    IEnumerator FlashRed()
    {
        spriteRenderer.color = Color.red; // Flash red instantly
        yield return new WaitForSeconds(0.2f); // Wait 0.2 seconds
        spriteRenderer.color = originalColor; // Return to normal color
    }
}