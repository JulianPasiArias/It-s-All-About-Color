using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBoxes : MonoBehaviour
{

    public GameObject boxes,boxesParent;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            boxes.SetActive(true);
            boxesParent.SetActive(true);
        }
    }
}
