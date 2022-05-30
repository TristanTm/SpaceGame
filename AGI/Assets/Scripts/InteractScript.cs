using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : Interactable
{

    public Dialogue dialogue;
    public GameObject Canvas;
    public GameObject Circle;
    public GameObject player;
    public GameObject MainCanvas;


    public override void interact()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        Canvas.SetActive(true);
        player.SetActive(false);
        MainCanvas.SetActive(false);
    }

    
}


