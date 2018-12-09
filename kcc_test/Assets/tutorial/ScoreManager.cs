using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static ScoreManager SMi;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        if (!SMi)
            SMi = this;
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
