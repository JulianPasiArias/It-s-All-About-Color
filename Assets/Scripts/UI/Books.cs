using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Books : MonoBehaviour
{
    public static int books;
    private TextMeshProUGUI textBooks;

    public static bool churchChangeColor = false;
    void Start()
    {
        textBooks = GetComponent<TextMeshProUGUI>();
        books = 0;
    }

   
    void Update()
    {
        textBooks.text = books.ToString();

        if(books == 4)
        {
            churchChangeColor = true;
        }
    }
}
