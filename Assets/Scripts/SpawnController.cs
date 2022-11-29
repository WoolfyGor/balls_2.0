using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SpawnController : MonoBehaviour
{
   [SerializeField] private GameController _gc;
    private bool _canSpawn = true;
   [SerializeField] GameObject CurrentSpawn;
    void Start()
    {
      _gc = GameController.Instance;
    }
    void Update()
    { 
        DetectTap();
    }
    public void DetectTap()
    {
        if (!_canSpawn)
            return;
        if (Input.GetMouseButtonDown(0)){
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                _gc.SpawnBallAtPosition(hit.point);
                _canSpawn = false;
                ReloadSpawnPoint();
            }
        }
    }
    private void ReloadSpawnPoint() 
    {
        SpriteRenderer sr = CurrentSpawn.GetComponent<SpriteRenderer>();
        Sequence seq = DOTween.Sequence();
        seq.Append(sr.DOFade(0.3f, 0.1f));
        seq.AppendInterval(0.3f);
        seq.Append(sr.DOFade(0.5f, 0.1f));
        seq.AppendCallback(() => _canSpawn = true);

    }
}

