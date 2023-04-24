using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    public bool frozen=false;

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
			}
            
		} else {
            horizontalMove = 0;
            jump = false;
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
