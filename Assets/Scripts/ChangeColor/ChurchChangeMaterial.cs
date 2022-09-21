using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChurchChangeMaterial : MonoBehaviour
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
        if(Books.churchChangeColor)
        {
            rend.sharedMaterial = material[1];
        }
    }
}
