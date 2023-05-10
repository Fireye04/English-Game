using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{   

    public GameObject thing;
    public float speed = 2f;

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
			this.gameObject.transform.position = Vector2.MoveTowards(transform.position, thing.transform.position, speed * Time.deltaTime);
		}

	}
}
