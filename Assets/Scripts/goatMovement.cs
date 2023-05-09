using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goatMovement : MonoBehaviour
{

	public goatController controller;
	public float runSpeed = 10f;
	float vMove = 0f;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		vMove = Input.GetAxisRaw("Vertical") * runSpeed;
	}

	private void FixedUpdate() {
		controller.GoatMove(vMove);
	}
}
