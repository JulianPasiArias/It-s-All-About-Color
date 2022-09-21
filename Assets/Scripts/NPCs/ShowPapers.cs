using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPapers : MonoBehaviour
{
    public GameObject papers, papersParent;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            papers.SetActive(true);
            papersParent.SetActive(true);
           
        }
    }

   
}
