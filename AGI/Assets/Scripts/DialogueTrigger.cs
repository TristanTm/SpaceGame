using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

	public Dialogue dialogue;
	public GameObject Canvas;
	public GameObject Circle;

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		Canvas.SetActive(true);
	}

    private void OnCollisionEnter(Collision collision)
    {
        TriggerDialogue();
		Destroy(this);
		Destroy(Circle);
    }

}
