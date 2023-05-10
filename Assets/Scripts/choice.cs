using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice : MonoBehaviour
{

    public GameObject sry;
    public GameObject notSry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sorry () {
		sry.SetActive(true);
	}

    public void not_sorry() {
        notSry.SetActive(true);
    }

}
