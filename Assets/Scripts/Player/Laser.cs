using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 20f;
    public float lifeSpan = 2f; 

    void Start()
    {
        Destroy(gameObject, lifeSpan);
    }

    void Update()
    {
        // Move the laser forward (to the right)
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy on collision other than player
        if (!collision.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }
}