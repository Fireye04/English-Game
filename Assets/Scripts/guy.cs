using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guy : MonoBehaviour, IInteractable
{	

	private game game;

	bool IInteractable.canInteract() {
		return true;
	}

	void IInteractable.Interact() {
		throw new System.NotImplementedException();
	}

	// Start is called before the first frame update
	void Awake()
    {
		game = GameObject.Find("Game").GetComponent<game>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.name == "Player") {
			game.setScore(game.getScore() + 1);
			Debug.Log(game.getScore());
			this.gameObject.SetActive(false);
		}
		
	}
}
