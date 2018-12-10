using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Manages player input through the loss screen
*/
public class LossScreen : MonoBehaviour
{
	public GameObject loss;

	public Button replayButton;

	public Button mainMenuButton;

	public AudioSource audiosource;

	public AudioClip hover;

	public string MainMenu;

	private string replay;

    void Start ()
	{
		replay = ResourcesScript.level;
		audiosource = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		replayButton.onClick.AddListener (Replay);
		mainMenuButton.onClick.AddListener (Quit);
	}


	public void Replay ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (replay);
	}

	public void Quit ()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (MainMenu);
	}

	public void onHover ()
	{
		audiosource.clip = hover;
		audiosource.Play ();
	}
}