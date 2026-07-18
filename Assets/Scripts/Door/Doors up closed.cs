using UnityEngine;

public class Door_destroy_when_4 : MonoBehaviour
{
    public PlayerInventory player;   // drag your Player object here in the Inspector

    void Update()
    {
        if (player.keysCollected >= 4)
        {
            Destroy(gameObject);
        }
    }
}
