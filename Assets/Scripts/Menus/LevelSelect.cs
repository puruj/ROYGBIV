using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Manages player input through the level select menu
*/
public class LevelSelect : MonoBehaviour
{
	public Button Hider2;

	public Button Hider3;

	public Button Hider4;

	public Button Hider5;

	public Button Hider6;

	public Button Hider7;

	public string Level1;

	public string Level2;

	public string Level3;

	public string Level4;

	public string Level5;

	public string Level6;

	public string Level7;

	public string MainMenu;

	public AudioSource audiosource;

	public AudioClip hover;

	public AudioClip click;

	void Awake ()
	{
		Cursor.visible = true;
		audiosource = GetComponent<AudioSource> ();

		if (PlayerPrefs.GetInt ("Level2") == 1 || ResourcesScript.cheat == 1) {
			Hider2.interactable = true;
		}

		if (PlayerPrefs.GetInt ("Level3") == 1 || ResourcesScript.cheat == 1) {
			Hider3.interactable = true;
		}

		if (PlayerPrefs.GetInt ("Level4") == 1 || ResourcesScript.cheat == 1) {
			Hider4.interactable = true;
		}

		if (PlayerPrefs.GetInt ("Level5") == 1 || ResourcesScript.cheat == 1) {
			Hider5.interactable = true;
		}

		if (PlayerPrefs.GetInt ("Level6") == 1 || ResourcesScript.cheat == 1) {
			Hider6.interactable = true;
		}

		if (PlayerPrefs.GetInt ("Level7") == 1 || ResourcesScript.cheat == 1) {
			Hider7.interactable = true;
		}
	}

	void Start ()
	{
		audiosource.clip = click;
		audiosource.Play ();
	}

	public void Levelone ()
	{
		SceneManager.LoadScene (Level1);
	}

	public void Leveltwo ()
	{
        if (PlayerPrefs.GetInt ("Level2") == 1 || ResourcesScript.cheat == 1) {
			SceneManager.LoadScene (Level2);
		}
	}

	public void Levelthree ()
	{
		if (PlayerPrefs.GetInt ("Level3") == 1 || ResourcesScript.cheat == 1) {
			SceneManager.LoadScene (Level3);
		}
	}

	public void Levelfour ()
	{
		if (PlayerPrefs.GetInt ("Level4") == 1 || ResourcesScript.cheat == 1) {
			SceneManager.LoadScene (Level4);
		}
	}

	public void Levelfive ()
	{
		if (PlayerPrefs.GetInt ("Level5") == 1 || ResourcesScript.cheat == 1) {
			SceneManager.LoadScene (Level5);
		}
	}

	public void Levelsix ()
	{
		if (PlayerPrefs.GetInt ("Level6") == 1 || ResourcesScript.cheat == 1) {
			SceneManager.LoadScene (Level6);
		}
	}

	public void Levelseven ()
	{
		if (PlayerPrefs.GetInt ("Level7") == 1 || ResourcesScript.cheat == 1) {
			SceneManager.LoadScene (Level7);
		}
	}

	public void Menu ()
	{
		SceneManager.LoadScene (MainMenu);
	}

	public void onHover ()
	{
		audiosource.clip = hover;
		audiosource.Play ();
	}
}