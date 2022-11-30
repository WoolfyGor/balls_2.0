using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionController : MonoBehaviour
{
    public static EvolutionController Instance;
    private ScoreboardController _sc;
    private GameController _gc;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            return;

    }
    private void Start()
    {
        _gc = GameController.Instance;
        _sc = ScoreboardController.Instance;
    }
    public void PerformEvolution(BallController firstBall, BallController secondBall)
    {
        Vector3 spawnBallPosition= Vector3.Lerp(firstBall.transform.position, secondBall.transform.position,0.5f);
        firstBall.ShrinkIn(true);
        secondBall.ShrinkIn(true);
        _sc.AddScore(firstBall._score);
        if (firstBall._tier == 8)
            return;
        _gc.SpawnBallAtPosition(spawnBallPosition,firstBall._tier);

       
    }
}
