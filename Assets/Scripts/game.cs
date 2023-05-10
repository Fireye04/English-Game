using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class game : MonoBehaviour
{
    private int score;
    public GameObject go;
    public GameObject goat;
    public GameObject bg;

    [Space]

    public GameObject scoree;
    public GameObject ending;

    public void setScore(int s) {
        score = s;
    }

    public int getScore() {
        return score;
    }

    public void gameOver() {
        bg.GetComponent<scroll>().setFreeze(true);
        goat.GetComponent<goatMovement>().setFreeze(true);
        goat.GetComponent<Animator>().SetBool("running", false);

		go.SetActive(true);

        scoree.GetComponent<TextMeshProUGUI>().text = "Your score: " + score.ToString();
        if (score == 0) {
            ending.GetComponent<TextMeshProUGUI>().text = "You got the pacifist ending!";
        } else if (0 < score && score < 10) {
			ending.GetComponent<TextMeshProUGUI>().text = "You got the weakling ending!";
		} else {
			ending.GetComponent<TextMeshProUGUI>().text = "You got the stone-hooved killer ending!";
		}


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
