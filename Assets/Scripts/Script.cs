// ReSharper disable RedundantUsingDirective
using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class Script : MonoBehaviour
{
    [FormerlySerializedAs("PaddleLeft")] [SerializeField] Transform paddleLeft;
    [FormerlySerializedAs("PaddleRight")] [SerializeField] Transform paddleRight;
    [FormerlySerializedAs("PaddleSpeed")] [SerializeField] float paddleSpeed = 6;

    [FormerlySerializedAs("BallRb")] [SerializeField] Rigidbody2D ballRb;
    [FormerlySerializedAs("BallSpeedMultiplier")] [SerializeField] float ballSpeed = 1000;
    
    [FormerlySerializedAs("ScoreLeft")] [SerializeField] TextMeshProUGUI scoreLeft;
    [FormerlySerializedAs("ScoreRight")] [SerializeField] TextMeshProUGUI scoreRight;

   
    private int _scoreLeft;
    private int _scoreRight;

    void Start()
    {
        paddleSpeed = paddleSpeed * 0.01f;

        NewRound();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = paddleLeft.position;
            newPosition.y -= paddleSpeed;
            paddleLeft.position = newPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = paddleLeft.position;
            newPosition.y += paddleSpeed;
            paddleLeft.position = newPosition;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPosition = paddleRight.position;
            newPosition.y -= paddleSpeed;
            paddleRight.position = newPosition;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = paddleRight.position;
            newPosition.y += paddleSpeed;
            paddleRight.position = newPosition;
        }

        if (ballRb.position.x > 8)
        {
            NewRound();
            _scoreLeft++;
            DisplayScore();
        }

        if (ballRb.position.x < -8)
        {
            NewRound();
            _scoreRight++;
            DisplayScore();
        }
    }

    private void DisplayScore()
    {
        scoreLeft.text = _scoreLeft.ToString();
        scoreRight.text = _scoreRight.ToString();
    }
    
    
    private void NewRound()
    {
        float angle = UnityEngine.Random.Range(math.PI/6, Mathf.PI/3);
        angle *= UnityEngine.Random.Range(1, 4);
        ballRb.position = new Vector2(x: 0, y: 0);
        ballRb.AddForce(new Vector2(x: Mathf.Cos(angle), y: Mathf.Sin(angle)) * ballSpeed);
    }
    
}
