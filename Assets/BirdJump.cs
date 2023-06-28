using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D RD2D;

    public float JumpY = 0.0f;
    void Start()
    {
        RD2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            RD2D.velocity = Vector2.up * JumpY;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.GameScore > Score.BestGameScore)
        {
            Score.BestGameScore = Score.GameScore;
        }
       
        SceneManager.LoadScene("GameOverScene");
    }
}
