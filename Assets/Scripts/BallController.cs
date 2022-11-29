using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int Tier, score;
    static int StartTier = 1;
    static int StartScore = 2;
    private void Start()
    {
        
    }
    private void RandomTier()
    {
        int tierProbabilty = Random.Range(0, 10);
        Tier = tierProbabilty < 7 ? 1 : 2;
        score = Tier * StartScore;
    }
}
