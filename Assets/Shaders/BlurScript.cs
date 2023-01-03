using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurScript : MonoBehaviour
{
    public Camera blurCamera;
    public Material blurMaterial;
    void Start()
    {
        if (blurCamera.targetTexture != null)
        {
            blurCamera.targetTexture.Release();
        }
        blurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height,24,RenderTextureFormat.ARGB32);
        blurMaterial.SetTexture("_RenderTexture", blurCamera.targetTexture);
    }

   
}
