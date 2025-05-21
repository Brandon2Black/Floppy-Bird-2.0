using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    
    Rigidbody2D bird;
    int score = 0;
    public Text scoreUI;
    public bool isAlive;
    public TextMeshProUGUI gameOverText;
    AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    public AudioClip audioClip5;

    // Start is called before the first frame update
  void Start()
{
   bird = GetComponent<Rigidbody2D>();

 isAlive = true;
 audioSource = GetComponent<AudioSource>();
}

public void GameOver()
{
    gameOverText.gameObject.SetActive(true);
    bird.constraints = RigidbodyConstraints2D.FreezePositionY;
    GetComponent<Animator>().enabled = false;
}

void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.CompareTag("Pipe"))
    {
    isAlive = false;
     audioSource.PlayOneShot(audioClip4);
    }

}

void OnTriggerEnter2D(Collider2D other)
{
    if(other.gameObject.CompareTag("Points"))
    {
        // Increase da score by one
        score += 1;

        scoreUI.text = score.ToString();

        audioSource.PlayOneShot(audioClip3);
    }
}

public void RestartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && isAlive == true)
    {
	bird.AddForce(new Vector2(0,1) * 200);
    audioSource.PlayOneShot(audioClip);
    }   

    if (isAlive == false)
    {
        GameOver();
        audioSource.PlayOneShot(audioClip2);
    }
    }
}
