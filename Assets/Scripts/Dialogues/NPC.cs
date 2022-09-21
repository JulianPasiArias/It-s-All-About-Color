using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;

    public bool inRange = false;

    
    public void TriggerDialogue()
    {
        FindObjectOfType<DIalogueManager>().StartDialogue(dialogue);
    }


    void OnTriggerEnter(Collider col)
    {
             PlayerMovement.isTalking = true;
            TriggerDialogue();
            inRange = true;
       
           

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            inRange = false;
            
        }
    }

    private void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DIalogueManager>().DisplayNextSentence();
        }
    }

    
}
