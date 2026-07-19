using UnityEngine;

public class FloatingFollower : MonoBehaviour
{
    public Transform player;
    public float speed = 1.5f;

    void Update()
    {
        if (player == null)
            return;

        // FLOAT TOWARD PLAYER
        transform.position = Vector3.Lerp(
            transform.position,
            player.position,
            speed * Time.deltaTime
        );

        // ROTATE BASED ON GRAVITY
        Vector2 g = Physics2D.gravity;

        if (g.y < 0)        // gravity down
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (g.y > 0)   // gravity up
            transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (g.x < 0)   // gravity left
            transform.rotation = Quaternion.Euler(0, 0, -90);
        else if (g.x > 0)   // gravity right
            transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
