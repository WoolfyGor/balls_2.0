using UnityEngine;

[CreateAssetMenu(fileName = "SkinData", menuName = "ScriptableObjects/SkinData", order = 1)]
public class SkinData : ScriptableObject
{
    public string SkinName;

    public Sprite[] tierSprites = new Sprite[8];
    public Sprite SkinPreview;
    public bool isLocked = false;
}