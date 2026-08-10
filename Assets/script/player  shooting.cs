using UnityEngine;

public class playersooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    void Update()
    {
        // Check if the player pressed left mouse button or Space
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Get mouse position in world space
        Vector2 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        mouseWorldPosition.z = 0f;

        // Calculate direction from player to mouse
        Vector2 direction = (mouseWorldPosition - transform.position).normalized;

        // Create the bullet
        GameObject bullet = Instantiate(
            bulletPrefab,
            transform.position,
            Quaternion.identity
        );

        // Give the bullet its direction
        bulletmovement bulletMovement = bullet.GetComponent<bulletmovement>();
        bulletMovement.SetDirection(direction);
    }
}