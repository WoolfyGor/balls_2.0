using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ArenaController : MonoBehaviour
{
    [SerializeField] private GameObject[] Arenas;
    public GameObject CurrentActiveArena;
    [SerializeField] private GameObject ArenaShape;
    // Start is called before the first frame update
    void Start()
    {
        SetArenaAsActive(SelectRandomArena());
    }

    public GameObject SelectRandomArena()
    {

        var arenaId = UnityEngine.Random.Range(0, Arenas.Length);
        return Arenas[arenaId];
    }
    public void SetArenaAsActive(GameObject arena)
    {
        CurrentActiveArena = arena;
        Instantiate(CurrentActiveArena, ArenaShape.transform);
    }

}
