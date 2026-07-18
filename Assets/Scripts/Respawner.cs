using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{

    // f steht für float
    [SerializeField]
    float y_spawn_pos = 1f;
    [SerializeField]
    float x_spawn_pos = -8f;

    [SerializeField]
    GameObject player_active;
    [SerializeField]
    GameObject playerModel;

    void SpawnPlayer(){
        Vector2 SpawnPoint = new Vector2(x_spawn_pos, y_spawn_pos);
        player_active = Instantiate(playerModel, SpawnPoint, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if(player_active == null){
            SpawnPlayer();
        }
    }
}
