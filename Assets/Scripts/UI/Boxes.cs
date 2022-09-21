using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Boxes : MonoBehaviour
{
    public static int boxes;
    private TextMeshProUGUI textBoxes;

    public static bool changeColorNature = false;



    void Start()
    {
        textBoxes = GetComponent<TextMeshProUGUI>();

        boxes = 0;


    }


    void Update()
    {
        textBoxes.text = boxes.ToString();

        if (boxes == 4)
        {
            changeColorNature = true;

        }


    }
}
