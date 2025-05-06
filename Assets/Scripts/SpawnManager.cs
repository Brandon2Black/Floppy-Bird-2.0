using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject pipePrefab;
    float randomHeight = 0.8f;
    // Start is called before the first frame update

    void SpawnPipes()
    {
      Instantiate(pipePrefab, new Vector2(12, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }

    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 2.5f);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
