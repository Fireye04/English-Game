using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour, IDrawn
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Label() {
		this.GetComponent<Animator>().SetBool("Labeled", true);
	}

}
