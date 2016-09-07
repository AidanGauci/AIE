using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public void LoadGameScene()
	{
		SceneManager.LoadScene ("BaseScene");
	}

	public void LoadMainMenu()
	{
		SceneManager.LoadScene ("BaseScene");
	}


	public void LoadEndMenu()
	{
		SceneManager.LoadScene ("BaseScene");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
