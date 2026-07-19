using UnityEngine;

public class DoorMoveWhen4_lvl4 : MonoBehaviour
{
    public PlayerInventory player;   // drag your Player here in the Inspector

    void Update()
    {
        if (player.keysCollected >= 4)
        {
            transform.position = new Vector3(-1, -3f, transform.position.z);
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);

        }
    }
}
