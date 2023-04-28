using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	 
	void OnTriggerEnter2D(Collider2D col) {

		var tempMonoArray = col.gameObject.GetComponents<MonoBehaviour>();

		Debug.Log(col.gameObject.name);

		foreach (var monoBehaviour in tempMonoArray) {
			var tempCollidable = monoBehaviour as IDialogueBox;

			if (tempCollidable != null) {
				tempCollidable.OnCollision();
				break;
			}

		}
	}
}
