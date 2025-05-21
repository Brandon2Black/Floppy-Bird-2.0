using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject pipePrefab;
    float randomHeight = 1.5f;
    // Start is called before the first frame update
    PlayerController PlayerControllerScript;

    void SpawnPipes()
    {
      Instantiate(pipePrefab, new Vector2(12, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }

    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 2.5f);

        PlayerControllerScript = GameObject.Find("Red_Bird_0").GetComponent<PlayerController>();
    }

    
    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.isAlive == false)
        {
          CancelInvoke();
        }
    }
}
