using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    //List of dialogues that will be chained together on this node.
    public List<DialogueInfo> Dialogues = new List<DialogueInfo>();

    public bool dialogueActive;
    public bool complete;
    public int i;

    // Start is called before the first frame update
    void Awake()
    {
        if (Dialogues.Count == 0) {
            complete = true;
        } else {
            i = 0;
        }
    }

    public void nextDialogue() {
        if (i < Dialogues.Count -1) {
            i++;
            //Todo, apply text and shit here
        }
    }

    // Update is called once per frame
    void Update() {
        if (dialogueActive) {
			if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0) {
                nextDialogue();
			}
		}
        
    }

	private void OnCollisionEnter2D(Collision2D collision) {
		if (!complete) {
            dialogueActive = true;
        }
	}

}
