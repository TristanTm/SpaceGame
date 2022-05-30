using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

	public Dialogue dialogue;
	public GameObject Canvas;
	public GameObject Circle;
	public GameObject player;
	public GameObject MainCanvas;
	public GameObject Heart;
	public GameObject text2;
	public GameObject text3;
	public GameObject task1;

	public void TriggerDialogue()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		Canvas.SetActive(true);
		player.SetActive(false);
		MainCanvas.SetActive(false);
		Heart.SetActive(true);
		text2.SetActive(false);
		text3.SetActive(false);
		task1.SetActive(true);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
		TriggerDialogue();
		Destroy(this);
		Destroy(Circle);
	}
}
