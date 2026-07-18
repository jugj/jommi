using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{   [SerializeField]
    float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
             transform.Translate(Vector2.right*Time.deltaTime*speed);
        }
       
       if(Input.GetKey("a")){
             transform.Translate(Vector2.left*Time.deltaTime*speed);
        }

        if(Input.GetKey("space")){
             transform.Translate(Vector2.up*Time.deltaTime*speed);
        }
    }
}
