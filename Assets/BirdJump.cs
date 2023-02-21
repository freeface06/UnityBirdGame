using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    
    public int jumpPower;

    public GameObject gameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOver.SetActive(false);
        InvokeRepeating ("ScoreStart", 0, 0.01f); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.bestScore < Score.score){
            Score.bestScore = Score.score;
        }
        gameOver.SetActive(true);
        CancelInvoke("ScoreStart");
    }

    public void ScoreStart(){
        Score.score += 0.01;
    }
}
