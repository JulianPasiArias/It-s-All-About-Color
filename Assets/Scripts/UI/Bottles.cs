using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bottles : MonoBehaviour
{
    public static int bottles;
    private TextMeshProUGUI textBottles;

    public static bool ranchChangeColor = false;



    void Start()
    {
        textBottles = GetComponent<TextMeshProUGUI>();

        bottles = 0;


    }


    void Update()
    {
        textBottles.text = bottles.ToString();

        if(bottles == 4)
        {
            ranchChangeColor = true;
        }

    }
}
