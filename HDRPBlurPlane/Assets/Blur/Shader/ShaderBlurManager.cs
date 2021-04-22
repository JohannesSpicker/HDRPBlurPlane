using UnityEngine;

public class ShaderBlurManager : MonoBehaviour
{
    public Camera   blurCamera;
    public Material blurMaterial;

    private void Start()
    {
        blurCamera.targetTexture?.Release();

        blurCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24, RenderTextureFormat.ARGB32, 1);
        blurMaterial.SetTexture("_MainTex", blurCamera.targetTexture);
    }
}