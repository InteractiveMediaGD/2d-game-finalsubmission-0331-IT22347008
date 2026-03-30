using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    void Update()
    {
        // Move left toward the player
        transform.Translate(Vector2.left * GameManager.GlobalSpeed * Time.deltaTime);

        // Destroy the object once it's well off-screen to save memory
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}