using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinPreview : MonoBehaviour
{
    [SerializeField] SkinData skinData;
    [SerializeField] Image img;
    [SerializeField] TextMeshProUGUI tmpro;

    private void Start()
    {
        ConfigureSkinPreview(skinData);
    }

    public void ConfigureSkinPreview(SkinData skinData)
    {
        img.sprite = skinData.SkinPreview;
        tmpro.text = skinData.SkinName;
    }
}
