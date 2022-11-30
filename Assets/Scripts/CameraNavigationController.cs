using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraNavigationController : MonoBehaviour
{
    [SerializeField] private GameObject MainCameraWaypoint, MenuWaypoint, PlayzoneWaypoint,ArenaSelectWaypoint,SkinSelectWaypoint;
    public static CameraNavigationController Instance;
    GameController _gc;
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            return;
    }

    void Start()
    {
        _gc = GameController.Instance;
        MainCameraWaypoint.transform.position = MenuWaypoint.transform.position;
    }

    public void StartRandomGame()
    {
        _gc.StartGame();
    }
    public void MoveToSkinSelect()
    {
        MainCameraWaypoint.transform.DOMove(SkinSelectWaypoint.transform.position, 1f);
    }
    public void MoveToPlayZone()
    {
        MainCameraWaypoint.transform.DOMove(PlayzoneWaypoint.transform.position, 1f);
    }
    public void MoveToArenaSelectZone()
    {
        MainCameraWaypoint.transform.DOMove(ArenaSelectWaypoint.transform.position, 1f);
    }
}
