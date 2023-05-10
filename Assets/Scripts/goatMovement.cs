using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goatMovement : MonoBehaviour
{

	public goatController controller;
	public float runSpeed = 10f;
	float vMove = 0f;
	public bool freeze;

	// Start is called before the first frame update
	void Start()
    {
        freeze = false;
    }

	public void setFreeze(bool f) {
		freeze = f;
	}

    // Update is called once per frame
    void Update()
    {
		if (!freeze) {
			vMove = Input.GetAxisRaw("Vertical") * runSpeed;
		} else {
			vMove = 0;
		}
	}

	private void FixedUpdate() {
		controller.GoatMove(vMove);
	}
}
