using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsChangeColor : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }


    void Update()
    {
        if (Papers.buildingsChangeColor)
        {
            rend.sharedMaterial = material[1];
        }
    }
}
