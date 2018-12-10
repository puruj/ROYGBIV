using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Manages player input through the pause menu
*/
public class PauseMenu : MonoBehaviour
{
	public Button replayButton;

	public Button mainmenuButton;

	public AudioSource audiosource;

	public AudioClip hover;

	public string mainmenu;

	private string replay;

	public bool mainMenuTest;

	public bool replayTest;

    void Start ()
	{
		replay = ResourcesScript.level;
		audiosource = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		replayButton.onClick.AddListener (Replay);
		mainmenuButton.onClick.AddListener (MainMenu);
	}

	public void Replay () //replay button
	{
		replayTest = true;	
		Time.timeScale = 1;
		SceneManager.LoadScene (replay);
	}

	public void MainMenu () //main menu button
	{
		mainMenuTest = true;
		Time.timeScale = 1;
		SceneManager.LoadScene (mainmenu);
	}

	public void onHover () //used to create effects when hovering over buttons
	{
		audiosource.clip = hover;
		audiosource.Play ();
	}
}