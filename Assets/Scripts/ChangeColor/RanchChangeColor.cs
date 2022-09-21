using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanchChangeColor : MonoBehaviour
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
        if (Bottles.ranchChangeColor)
        {
            rend.sharedMaterial = material[1];
        }
    }
}
