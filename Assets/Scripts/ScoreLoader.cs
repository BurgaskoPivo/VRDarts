using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreLoader : MonoBehaviour
{

    public int HighScore;
    public int CurrentScore;

    private float timeInSeconds = 10f;

	void Start ()
	{
	    this.HighScore = PlayerPrefs.GetInt("HighScore");
	    this.CurrentScore = PlayerPrefs.GetInt("CurrentScore");

	    if (this.CurrentScore > this.HighScore)
	    {
	        this.HighScore = this.CurrentScore;
            PlayerPrefs.SetInt("HighScore", this.HighScore);
	    }

	    this.StartCoroutine(this.Countdown());
	}

    public IEnumerator Countdown()
    {
        yield return new WaitForSecondsRealtime(this.timeInSeconds);

        SceneManager.LoadSceneAsync("UpgradedMain");
    }
}
