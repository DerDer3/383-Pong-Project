using UnityEngine;
using TMPro;
using System.Transactions;

public class Scoreboard : MonoBehaviour
{

    int rightScore = 0;
    int leftScore = 0;
    public TMP_Text CurrentScore;
    public Transform CanvasLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentScore = Instantiate(CurrentScore, CanvasLayer);
    }

    void OnEnable()
    {
        Ball.OnPointScored += HandlePointScored; 
    }

    public void HandlePointScored(string player)
    {
        if (player == "Right")
        {
            rightScore += 1;
        }
        else
        {
            leftScore += 1;
        }

        CurrentScore.text = leftScore + " - " + rightScore;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
