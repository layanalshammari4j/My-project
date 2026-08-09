using UnityEngine;

public class Shoot : MonoBehaviour
{

    public float speed = 5f; // Movement speed, adjustable in Inspector

    void Start()
    {
        // Runs once when the game starts
    }

    void Update()
    {
        // Runs every frame while the game is running
        Vector3 movement = Vector3.zero; // Reset movement each frame

        // Check horizontal input (right/left)
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            movement.x = 1f;
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            movement.x = -1f;

        // Check vertical input (up/down)
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            movement.y = 1f;
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            movement.y = -1f;

        // Apply movement, scaled by speed and frame time
        transform.position += movement * speed * Time.deltaTime;
    }

}