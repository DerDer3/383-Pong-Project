using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Paddle paddle;
    public Ball ball;

    public Canvas pauseMenu;

    public static bool isPaused = true;

    Vector2 savedVelocity;
    string input;
    public static Vector2 bottomLeft; 
    public static Vector2 topRight;
    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Instantiate(ball);
        Paddle paddle1 = Instantiate(paddle) as Paddle;
        Paddle paddle2 = Instantiate(paddle) as Paddle;
        paddle1.Init(true);
        paddle2.Init(false);

        pauseMenu.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (!isPaused && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed, Game is Paused");
            isPaused = true;
            pauseMenu.enabled = true;
        }
        else if (isPaused && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Pressed, Game is Unpaused");
            isPaused = false;
            pauseMenu.enabled = false;
        }
    }
}
