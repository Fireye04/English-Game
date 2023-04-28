using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Door : MonoBehaviour, IInteractable, IDrawn {

    public Animator animator;

    public void Interact() {
        if (animator.GetBool("Opened")) {
            animator.SetBool("Opened", false);
        } else {
			animator.SetBool("Opened", true);
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
