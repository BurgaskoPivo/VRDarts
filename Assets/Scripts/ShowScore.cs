using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{

    public Text HighScore;
    public Text CurrentScore;

    public ScoreLoader ScoreLoader;

	void Start ()
	{
	    this.HighScore.text = "High Score: " + this.ScoreLoader.HighScore;
	    this.CurrentScore.text = "Your Score: " + this.ScoreLoader.CurrentScore;
	}
}
