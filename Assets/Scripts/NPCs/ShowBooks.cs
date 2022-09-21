using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBooks : MonoBehaviour
{
    public GameObject books, booksParent;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            books.SetActive(true);
            booksParent.SetActive(true);
        }
    }
}
