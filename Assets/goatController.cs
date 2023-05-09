using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goatController : MonoBehaviour
{

	private Rigidbody2D m_Rigidbody2D; 
	[Range(0, .3f)][SerializeField] private float m_MovementSmoothing = .05f;
	private Vector3 m_Velocity = Vector3.zero;
	// Start is called before the first frame update
	void Start()
    {
		m_Rigidbody2D = GetComponent<Rigidbody2D>();

	}

    // Update is called once per frame
    void Update()
    {
		

	}

	public void GoatMove(float move) {
		Vector3 targetVelocity = new Vector2(m_Rigidbody2D.velocity.x, move * 10f);
		// And then smoothing it out and applying it to the character
		m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
	}
}
