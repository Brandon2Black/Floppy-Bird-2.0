using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    Vector3 startPos;
    float repeatWidth;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = startPos.x - time;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
