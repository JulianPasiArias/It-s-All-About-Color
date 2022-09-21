using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOrDisableScript : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
