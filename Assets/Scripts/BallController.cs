using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BallController : MonoBehaviour
{
    public int _tier, _score;
    static int StartTier = 1;
    static int StartScore = 2;
    public bool _spawner = true;
    private bool evolvable = true;
    [SerializeField] SpriteRenderer _sr;
    private float _shrinkTime = 0.1f;
    private void Awake()
    {
        transform.localScale = Vector2.zero;
    }
    private void Start()
    {
        if(_tier==0)
            RandomTier();
        SetScore(_tier);
        SetColorByTier(_tier);
        ShrinkOut();
    }

    private void ShrinkOut() 
    {
        float multipler = (float)_tier / 10f;
        transform.DOScale(new Vector3(1 + multipler, 1 + multipler, 1 + multipler), _shrinkTime);
    }   
    public void ShrinkIn(bool mustDestroy = false)
    {
        Sequence seq = DOTween.Sequence();
        Rigidbody2D rb;
        gameObject.TryGetComponent<Rigidbody2D>(out rb);
        if(rb!=null)
            seq.InsertCallback(0,() => Destroy(rb));
        seq.Append(transform.DOScale(Vector3.zero, _shrinkTime/2));
        if (mustDestroy)
            seq.AppendCallback(() => Destroy(gameObject));
    }

    private void RandomTier()
    {
        int tierProbabilty = Random.Range(0, 10);
        _tier = tierProbabilty < 7 ? 1 : 2;
    }
    private void SetScore(int Tier)
    {
        _score = (int)Mathf.Pow(StartScore, Tier);
    }
    private void SetColorByTier(int tier)
    {
        Color colorToSet = Color.white;
        switch (tier)
        {
            case 1:
                colorToSet = Color.blue;
                break;
            case 2:
                colorToSet = Color.red;
                break;
            case 3:
                colorToSet = Color.cyan;
                break;
            case 4:
                colorToSet = Color.green;
                break;
            case 5:
                colorToSet = Color.yellow;
                break;
            case 6:
              
                break;
            case 7:
                break;
            case 8:
                break;
            default:
                colorToSet = Color.black;
                break;
        }
        _sr.color = colorToSet;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallController _bc;
        collision.transform.TryGetComponent<BallController>(out _bc);
        if (collision.transform.CompareTag("Ball")&& _bc!=null)
        {
            if (!_spawner)
                return;
            if(_bc._tier == _tier) 
            {
                _bc._spawner = false;
                EvolutionController.Instance.PerformEvolution(this, collision.gameObject.GetComponent<BallController>());
            }
        }
    }
}

