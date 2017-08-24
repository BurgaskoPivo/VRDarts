using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetCounter : MonoBehaviour
{

    public int TargetCount;
	
	void Update () {
	    if (this.TargetCount <= 0)
	    {

            //PlayerPrefs.SetInt("CurrentScore", ScoreManager.Score);
	        //SceneManager.LoadSceneAsync("WinScreen");
	    }
	}
}
