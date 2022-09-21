using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private bool endGame = false;

    public GameObject barrier1, barrier2, endGameCanvas, signalCanvas;
    
    public Material[] material;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }


    void Update()
    {
        if(Bottles.ranchChangeColor && Papers.buildingsChangeColor && Boxes.changeColorNature && Books.churchChangeColor)
        {
            endGame = true;
        }

        OpenTunnel();
    }

    void OpenTunnel()
    {
        if(endGame)
        {
            signalCanvas.SetActive(true);
            rend.sharedMaterial = material[1];
            Destroy(barrier1);
            Destroy(barrier2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && endGame)
        {
            endGameCanvas.SetActive(true);
            Invoke("Load", 2);
        }
    }

    private void Load()
    {
        SceneManager.LoadScene(1);
    }
}
