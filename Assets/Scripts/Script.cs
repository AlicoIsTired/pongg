using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] Transform PaddleLeft;
    [SerializeField] Transform PaddleRight;
    [SerializeField] float PaddleSpeed = 6;

    [SerializeField] Rigidbody2D BallRb;
    [SerializeField] float BallSpeedMultiplier = 1000;
    
    [SerializeField] TextMeshPro ScoreLeft;
    [SerializeField] TextMeshPro ScoreRight;

   
    private int _scoreLeft = 0;
    private int _scoreRight = 0;

    void Start()
    {
        PaddleSpeed = PaddleSpeed * 0.01f;

        NewRound();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = PaddleLeft.position;
            newPosition.y -= PaddleSpeed;
            PaddleLeft.position = newPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = PaddleLeft.position;
            newPosition.y += PaddleSpeed;
            PaddleLeft.position = newPosition;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPosition = PaddleRight.position;
            newPosition.y -= PaddleSpeed;
            PaddleRight.position = newPosition;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = PaddleRight.position;
            newPosition.y += PaddleSpeed;
            PaddleRight.position = newPosition;
        }

        if (BallRb.position.x > 8)
        {
        }
    }

    private void NewRound()
    {
        float xVelocity = (UnityEngine.Random.value * BallSpeedMultiplier * 3) - 1.5f  * BallSpeedMultiplier;
        float yVelocity = (UnityEngine.Random.value * BallSpeedMultiplier) - 0.5f * BallSpeedMultiplier;
        Vector2 a = new Vector2(xVelocity, yVelocity);
        //quaternion.Euler(0f,0f, UnityEngine.Random)
        BallRb.position = new Vector2(x: 0, y: 0);
        BallRb.AddForce(new Vector2(x: xVelocity, y: yVelocity));
    }
    
}
