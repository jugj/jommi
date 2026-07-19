using UnityEngine;

public class DoorMoveWhen4_lvl3 : MonoBehaviour
{
    public PlayerInventory player;   // drag your Player here in the Inspector

    void Update()
    {
        if (player.keysCollected >= 4)
        {
            transform.position = new Vector3(transform.position.x, -11f, transform.position.z);

        }
    }
}
