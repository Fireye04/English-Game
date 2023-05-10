using System.Collections;
using System.Collections.Generic;
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
        
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "Player") {
            anim.SetTrigger("Fall");
            

			SceneManager.LoadSceneAsync("Stickman 1");
		}
    }
}
