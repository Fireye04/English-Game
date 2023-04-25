using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    public bool frozen=false;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (!frozen) {
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

			if (Input.GetButtonDown("Jump")) {
				jump = true;
                animator.SetBool("Jump", true);
			}
            
		} else {
            horizontalMove = 0;
            jump = false;
        }

        animator.SetInteger("Movement", ((int)horizontalMove));
        if (controller.m_Grounded && !jump) {
			animator.SetBool("Jump", false);
		}
        
    }

	void FixedUpdate() {
		controller.Move(horizontalMove, jump);
        jump = false;
		
	}

    public void setFrozen(bool froz) {
        frozen = froz;
    }

}
