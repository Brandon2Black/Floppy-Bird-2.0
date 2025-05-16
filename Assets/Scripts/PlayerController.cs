using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D bird;
    int score = 0;
    public Text scoreUI;
    public bool isAlive;
    // Start is called before the first frame update
  void Start()
{
   bird = GetComponent<Rigidbody2D>();

 isAlive = true;

}

void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.CompareTag("Pipe"))
    {
    isAlive = false;
    }

}

void OnTriggerEnter2D(Collider2D other)
{
    if(other.gameObject.CompareTag("Points"))
    {
        // Increase da score by one
        score += 1;

        scoreUI.text = score.ToString();
    }
}


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && isAlive == true)
    {
	bird.AddForce(new Vector2(0,1) * 200);
    }   
    }
}
