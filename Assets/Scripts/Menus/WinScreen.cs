using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Manages player input through the win screen
*/
public class WinScreen : MonoBehaviour
{
	public GameObject win;

	public Button nextLevelButton;

	public Button replayButton;

	public Button MainMenuButton;

	public AudioSource audiosource;

	public AudioClip hover;

	public string mainMenu;

	private string replay;

	private string nextLevel;

	void Start ()
	{
		replay = ResourcesScript.level;
		audiosource = GetComponent<AudioSource> ();
		int nextLevelNumber = int.Parse (replay.Substring (replay.Length - 1));
		nextLevelNumber++;
		nextLevel = "Level" + nextLevelNumber;
		PlayerPrefs.SetInt (nextLevel, 1);
	}

	void Update ()
	{
		nextLevelButton.onClick.AddListener (NextLevel);
		replayButton.onClick.AddListener (Replay);
		MainMenuButton.onClick.AddListener (Quit);
	}

	public void NextLevel ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (nextLevel);
	}

	public void Replay ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (replay);
	}

	public void Quit ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (mainMenu);
	}

	public void onHover ()
	{
		audiosource.clip = hover;
		audiosource.Play ();
	}
}