using UnityEngine;

public class Key_collect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerInventory>().keysCollected++;
            Destroy(gameObject);
        }
    }
}

