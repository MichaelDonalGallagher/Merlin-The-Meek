using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float SSpeed = 0.1f;
    private MeshRenderer mesh_Renderer;
    private Vector2 saved_offset;

    // Start is called before the first frame update
    void Start()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
        saved_offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
    }

    void Update()
    {
        float x = Time.time * SSpeed;

        Vector2 offset = new Vector2(x, 0);

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    private void OnDisable()
    {
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", saved_offset);
    }
}
