using UnityEngine;

public class DoorMoveWhen4 : MonoBehaviour
{
    public PlayerInventory player;   // drag your Player here in the Inspector

    void Update()
    {
        if (player.keysCollected >= 4)
        {
            transform.position = new Vector3(transform.position.x, -2f, transform.position.z);

        }
    }
}
