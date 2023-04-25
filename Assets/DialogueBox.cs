using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DialogueBox : MonoBehaviour, IDialogueBox
{
    //List of dialogues that will be chained together on this node.
    public List<DialogueInfo> Dialogues = new List<DialogueInfo>();

    public bool dialogueActive;
    public bool complete;

    public GameObject TextBox;

    private int i;

    // Start is called before the first frame update
    void Awake()
    {
        if (Dialogues.Count == 0) {
            complete = true;
        } else {
            i = -1;
        }
    }

    public void nextDialogue() {
        if (i+1 < Dialogues.Count -1) {
            i++;
            //Todo, apply text and shit here
        } else {
            complete = true;
            dialogueActive = false;
        }
    }

    // Update is called once per frame
    void Update() {
        if (dialogueActive) {
			if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0)) {
                nextDialogue();
			}
		}
        
    }

	void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("work");
        if (collision.gameObject.name != "Player") {
            return;
        }

        if (complete) {
            return;
        }

        GameObject name = GameObject.Find("Text Div/Character name");
		GameObject body = GameObject.Find("Text Div/Dialogue");

        Debug.Log(name);
        Debug.Log(body);

		TextBox.SetActive(true);

        dialogueActive = true;
    }

    public bool getActive() {
        return dialogueActive;
    }

    public bool getComplete() {
        return complete;
    }

    public void setActive(bool active) {
        dialogueActive=active;
    }

    public void setComplete(bool completed) {
        complete=completed;
    }
}
