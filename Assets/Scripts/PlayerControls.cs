using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 g = Physics2D.gravity;

        // ROTATION BASED ON GRAVITY DIRECTION
        if (g.y < 0)        // gravity down
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (g.y > 0)   // gravity up
            transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (g.x < 0)   // gravity left
            transform.rotation = Quaternion.Euler(0, 0, -90);
        else if (g.x > 0)   // gravity right
            transform.rotation = Quaternion.Euler(0, 0, 90);

        // ⭐ ALWAYS THE SAME CONTROLS ⭐
        if (Input.GetKey("d"))
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (Input.GetKey("a"))
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (Input.GetKey("space"))
            transform.Translate(Vector2.up * speed * Time.deltaTime);

        // ⭐ FIX #1 — F always sets gravity UP (from ANY direction)
        if (Input.GetKeyDown(KeyCode.F))
        {
            Physics2D.gravity = new Vector2(0f, 9.81f);
        }

        // Gravity RIGHT
        if (Input.GetKeyDown(KeyCode.G))
        {
            Physics2D.gravity = new Vector2(9.81f, 0f);
        }

        // Gravity LEFT
        if (Input.GetKeyDown(KeyCode.H))
        {
            Physics2D.gravity = new Vector2(-9.81f, 0f);
        }

        // Reset DOWN
        if (Input.GetKeyDown(KeyCode.J))
        {
            Physics2D.gravity = new Vector2(0f, -9.81f);
        }
    }
}
