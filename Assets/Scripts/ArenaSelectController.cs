using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaSelectController : MonoBehaviour
{
    [SerializeField] GameObject BoxArena, CircleArena, TriangleArena;

    GameController _gc;
    // Start is called before the first frame update
    void Start()
    {
        _gc = GameController.Instance; 
    }

    public void SelectBoxArena()
    {
        _gc.StartGame(BoxArena);
    }
    public void SelectCircleArena()
    {
        _gc.StartGame(CircleArena);
    }
    public void SelectTriangleArena()
    {
        _gc.StartGame(TriangleArena);
    }

}
