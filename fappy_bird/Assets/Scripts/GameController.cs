using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	public bool gameOver = false;
    public int score = 0;
    public static GameController instance;

    public GameObject StartPage;
    public GameObject GameOverPage;
    public Text ScoreText;

    enum PageState
    {
	    None, 
	    Start, 
	    GameOver
    }
    
	void Awake()
	{
		instance = this;
	}

	void OnEnable()
	{
		Fappy.OnPlayerScored += OnPlayerScored;
	}

	private void OnDisable()
	{
		Fappy.OnPlayerScored -= OnPlayerScored;
	}
	

	void OnPlayerScored()
	{
		score++;
		ScoreText.text = score.ToString();
	}
	
	
	void SetPageState(PageState state)
	{
		switch (state)
		{
			case PageState.None:
				StartPage.SetActive(false);
				GameOverPage.SetActive(false);
				break;
			
			case PageState.Start:
				StartPage.SetActive(true);
				GameOverPage.SetActive(false);
				break;
			
			case PageState.GameOver:
				StartPage.SetActive(false);
				GameOverPage.SetActive(true);
				break;
		}
	}
}
