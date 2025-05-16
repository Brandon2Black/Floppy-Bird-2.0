using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float Speed = 2.5f;
    PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Awake()
    {
        playerControllerScript = GameObject.Find("Red_Bird_0").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
      if(playerControllerScript.isAlive == true)
      {
      transform.Translate(Vector2.left * Time.deltaTime * Speed);
      }
      else
      {
        Speed = 0;
      }
      //pipe movement

    
        
    }
}
