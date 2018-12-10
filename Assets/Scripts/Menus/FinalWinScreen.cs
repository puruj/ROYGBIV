using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Manages player input through the final win screen
*/
public class FinalWinScreen : MonoBehaviour
{
	public GameObject win;

	public Button replayButton;

	public Button MainMenuButton;

	public AudioSource audiosource;

	public AudioClip hover;

	public string mainMenu;

	private string replay;

    void Start ()
	{
		replay = ResourcesScript.level;
		audiosource = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		replayButton.onClick.AddListener (Replay);
		MainMenuButton.onClick.AddListener (Quit);
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