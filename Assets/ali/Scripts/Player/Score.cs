using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int score;
    public Text scoreText;

    void Awake()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

	// Use this for initialization
	void LateUpdate () {
        scoreText.text = "Score: " + score;
	}
	
}
