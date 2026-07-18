using UnityEngine;

public class DoorMoveWhen4_lvl2 : MonoBehaviour
{
    public PlayerInventory player;   // drag your Player here in the Inspector

    void Update()
    {
        if (player.keysCollected >= 4)
        {
            // Rotate door to -90 degrees
            transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        }
    }
}
