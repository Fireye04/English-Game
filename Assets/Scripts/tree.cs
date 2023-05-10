using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour, IDrawn
{
	public void Label() {
        this.GetComponent<Animator>().SetBool("Labeled", true);
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
