using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField] private bool isInRange = false;

    public GameObject canvas;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Bottles.bottles += 1;
                canvas.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            isInRange = true;
            canvas.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            canvas.SetActive(false);
        }
    }
}
