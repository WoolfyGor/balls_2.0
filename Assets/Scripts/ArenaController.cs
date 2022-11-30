using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ArenaController : MonoBehaviour
{
    [SerializeField] private GameObject[] Arenas;
    public GameObject CurrentActiveArena;
    [SerializeField] private GameObject ArenaShape;
    SpawnController _sc;
    // Start is called before the first frame update
    void Start()
    {
        _sc = SpawnController.Instance;
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
        var newArena = Instantiate(CurrentActiveArena, ArenaShape.transform);
        _sc.CurrentSpawn = newArena.transform.Find("SpawnArea").gameObject;

    }

}
