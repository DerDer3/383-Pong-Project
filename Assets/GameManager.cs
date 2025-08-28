using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Paddle paddle;
    public Ball ball;
    public static Vector2; 
    void Start()
    {
        Instantiate(ball);
        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;
        paddle1.Init(true);
        paddle2.Init(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
