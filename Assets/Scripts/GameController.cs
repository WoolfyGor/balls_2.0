using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameController Instance;
   
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
            Instance = this;
        else
            return;
    }

    public void SpawnBallAtPosition(Vector3 position,GameObject ball)
    {
        GameObject obj = Instantiate(ball, new Vector3(position.x,position.y, 0), Quaternion.identity) as GameObject;
    }
}