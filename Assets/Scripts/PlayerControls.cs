using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] TextMeshProUGUI timerText;

    private Rigidbody2D rb;
    private float timer = 10f;

    // Gravity directions
    private enum GravDir { Down, Up, Left, Right }
    private GravDir currentDir = GravDir.Down;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetGravity(GravDir.Down);   // start normal
    }

    void Update()
    {
        Vector2 g = Physics2D.gravity;

        // TIMER
        timer -= Time.deltaTime;

        // ⭐ FIX: Prevent crash if timerText is not assigned
        if (timerText != null)
        {
            timerText.text = Mathf.Ceil(timer).ToString();
        }

        if (timer <= 0f)
        {
            ChangeGravityRandom();
            timer = 10f; // reset timer
        }

        // ROTATION BASED ON GRAVITY DIRECTION
        if (g.y < 0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (g.y > 0)
            transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (g.x < 0)
            transform.rotation = Quaternion.Euler(0, 0, -90);
        else if (g.x > 0)
            transform.rotation = Quaternion.Euler(0, 0, 90);

        // ⭐ ALWAYS THE SAME CONTROLS ⭐
        if (Input.GetKey("d"))
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (Input.GetKey("a"))
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (Input.GetKey("space"))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    // -----------------------------
    // GRAVITY SYSTEM
    // -----------------------------

    void ChangeGravityRandom()
    {
        GravDir newDir;

        do
        {
            newDir = (GravDir)Random.Range(0, 4);
        }
        while (newDir == currentDir); // avoid repeating same direction

        SetGravity(newDir);
    }

    void SetGravity(GravDir dir)
    {
        currentDir = dir;

        switch (dir)
        {
            case GravDir.Down:
                Physics2D.gravity = new Vector2(0f, -9.81f);
                break;

            case GravDir.Up:
                Physics2D.gravity = new Vector2(0f, 9.81f);
                break;

            case GravDir.Left:
                Physics2D.gravity = new Vector2(-9.81f, 0f);
                break;

            case GravDir.Right:
                Physics2D.gravity = new Vector2(9.81f, 0f);
                break;
        }
    }
}
