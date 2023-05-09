using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, IInteractable, IDrawn {

    public Animator animator;

	private bool interactable;

	public string scene;

	void Awake() {
		interactable = true;
	}

	public bool canInteract() {
		return interactable;
	}

	public void Interact() {
        if (animator.GetBool("Opened")) {
            animator.SetBool("Opened", false);
		} else {
			animator.SetBool("Opened", true); 
			SceneManager.LoadSceneAsync(scene);
		}
    }

    public void Label() {
		if (animator.GetBool("Labeled")) {
			animator.SetBool("Labeled", false);
		} else {
			animator.SetBool("Labeled", true);
		}
	}
}
