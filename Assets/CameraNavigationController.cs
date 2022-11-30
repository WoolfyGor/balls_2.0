using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraNavigationController : MonoBehaviour
{
    [SerializeField] private GameObject MainCameraWaypoint, MenuWaypoint, PlayzoneWaypoint;

    void Start()
    {
        MainCameraWaypoint.transform.position = MenuWaypoint.transform.position;
    }

    public void MoveToPlayZone()
    {
        MainCameraWaypoint.transform.DOMove(PlayzoneWaypoint.transform.position, 1f);
    }
}
