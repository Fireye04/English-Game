using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class barFall : MonoBehaviour
{

    public Animator anim;

	public List<DialogueInfo> Dialogues = new List<DialogueInfo>();

	public bool dialogueActive;
	public bool complete;

	public GameObject Player;

	public GameObject TextBox;
	public GameObject Character;
	public GameObject Body;
	public GameObject Continue;

	public AudioSource AudioSource;
	private bool audioInProgress;

	private int i;

	// Start is called before the first frame update
	void Awake()
    {
		if (Dialogues.Count == 0) {
			complete = true;
		} else {
			i = 0;
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (dialogueActive) {
			if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Mouse0)) {
				if (AudioSource.isPlaying) {
					AudioSource.Stop();
					audioInProgress = false;
				}
				nextDialogue();
			}

			if (!AudioSource.isPlaying && audioInProgress) {
				Continue.SetActive(true);
				audioInProgress = false;
			}
		}

	}



    private void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.name == "Player") {
			if (complete) {
				return;
			}

			TextBox.SetActive(true);
			Player.GetComponent<PlayerMovement>().setFrozen(true);

			applyText();

		}


		

    }

	public DialogueInfo getCurrentDialogue() {
		return Dialogues[i];
	}

	public void nextDialogue() {
		if (i + 1 <= Dialogues.Count - 1) {
			i++;
			Continue.SetActive(false);
			applyText();
			//Todo, apply text and shit here
		} else {
			complete = true;
			dialogueActive = false;
			TextBox.SetActive(false);
			Player.GetComponent<PlayerMovement>().setFrozen(false);
			SceneManager.LoadSceneAsync("Dialogue");
		}
	}

	public void applyText() {
		Character.GetComponent<TextMeshProUGUI>().text = getCurrentDialogue().Character.ToString();
		Body.GetComponent<TextMeshProUGUI>().text = getCurrentDialogue().text;

		dialogueActive = true;

		AudioSource.clip = getCurrentDialogue().clip.clip;
		AudioSource.Play();
		audioInProgress = true;
	}

}
