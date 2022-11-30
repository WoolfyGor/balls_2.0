using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelectController : MonoBehaviour
{
    [SerializeField]SkinData[] AllSkins;
    [SerializeField] GameObject SkinsGalleryHolder;
    [SerializeField] GameObject SkinPreviewPrefab;
    private void Start()
    {
        AddSkinsToGallery();
    }

    private void AddSkinsToGallery() 
    {
        int startX = 135;
        foreach(var skin in AllSkins)
        {
            var newSkin = Instantiate(SkinPreviewPrefab, SkinsGalleryHolder.transform);
            var skinPreview = newSkin.GetComponent<SkinPreview>();
            skinPreview.ConfigureSkinPreview(skin);
            newSkin.transform.localPosition = new Vector2(startX, newSkin.transform.localPosition.y);
            startX += 135;
        }
        var skinWidth = 135 * AllSkins.Length;
        if (AllSkins.Length > 3)
            skinWidth -= 135 ;
        SkinsGalleryHolder.GetComponent<RectTransform>().sizeDelta = new Vector2(skinWidth, 0);

    }
}
