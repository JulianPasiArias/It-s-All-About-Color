using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Papers : MonoBehaviour
{
    public static int papers;
    private TextMeshProUGUI textPapers;

    public static bool buildingsChangeColor = false;



    void Start()
    {
        textPapers = GetComponent<TextMeshProUGUI>();

        papers = 0;


    }


    void Update()
    {
        textPapers.text = papers.ToString();

        if(papers == 4)
        {
            buildingsChangeColor = true;
        }


    }
}
