using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]public static GameController Instance;
    [SerializeField] private GameObject ball;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            return;
    }

    public void SpawnBallAtPosition(Vector3 position, int startTier = 0)
    {
        GameObject obj = Instantiate(ball, new Vector3(position.x,position.y, 0), Quaternion.identity) as GameObject;
        if (startTier != 0)
        {
            obj.GetComponent<BallController>()._tier = startTier+1;
        }
    }
    
    public void TriggerGameOver()
    {
        Debug.LogWarning("Lose");
    }
}