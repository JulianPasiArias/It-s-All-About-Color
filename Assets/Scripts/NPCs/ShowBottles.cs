using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBottles : MonoBehaviour
{
    public GameObject bottles, bottlesParent;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bottles.SetActive(true);
            bottlesParent.SetActive(true);
        }
    }
}
