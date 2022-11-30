using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardController : MonoBehaviour
{
    public static ScoreboardController Instance;
    [SerializeField] private GameObject ScoreHolder;
    private TextMeshProUGUI scoreTM;
    public int currentScore = 0;

    void Awake() 
    {
        if (Instance == null)
            Instance = this;
        else
            return;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreTM = ScoreHolder.GetComponent<TextMeshProUGUI>();
        SetScore();
    }
    public void AddScore(int score)
    {
        currentScore += score;
        SetScore();
    }
    public void SetScore() 
    {
        scoreTM.text = currentScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
