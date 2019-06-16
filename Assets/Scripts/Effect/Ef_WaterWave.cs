using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_WaterWave : MonoBehaviour
{
    public Texture[] textures;
    public Material material;
    private int index = 0;

    // Use this for initialization
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        InvokeRepeating("ChangeTexture", 0f, 0.1f);
    }

    void ChangeTexture()
    {
        material.mainTexture = textures[index];
        index = (index + 1) % textures.Length; //0+1 / 5 = 4 ,  1+1 / 5 = 3, 3+1/5 = 2, 4+1/5=1
    }
}