using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour {

	public AudioSource buttonPress;
	public int bestScore;
	public GameObject bestScoreDiplay;

	void Start()
	{
		Cursor.visible = true;
		bestScore = PlayerPrefs.GetInt ("LevelScore");
		bestScoreDiplay.GetComponent<Text> ().text = "BEST : " + bestScore;
	}
	 
	public void PlayGame(){
		buttonPress.Play ();
		RedirectToLevel.redirectToLevel = 3;
		SceneManager.LoadScene (2);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void ResetBest()
	{
		PlayerPrefs.SetInt ("LevelScore", 0);
		PlayerPrefs.SetInt ("LevelScore5", 0);
		bestScoreDiplay.GetComponent<Text> ().text = "BEST : " + bestScore;
	}
}
