using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
	public string instructions;

	public string cameraM;

	public string sound;

	public string settings;

	public string mainmenu;

	public AudioSource audiosource;

	public AudioClip hover;

	public AudioClip click;

	void Awake ()
	{
		Cursor.visible = true;
		audiosource = GetComponent<AudioSource> ();
	}

	void Start ()
	{
		audiosource.clip = click;
		audiosource.Play ();
	}

	public void Instructions ()
	{
		SceneManager.LoadScene (instructions);
	}

	public void Camera ()
	{
		SceneManager.LoadScene (cameraM);
	}

	public void ResetGame ()
	{
		if (ResourcesScript.resetCounter < 4) {
			ResourcesScript.resetCounter++;
			ResourcesScript.cheat = 0;
            ResourcesScript.highScore = Mathf.Max(ResourcesScript.highScore, PlayerPrefs.GetInt("highScore"));
			PlayerPrefs.SetInt ("Level2", 0);
			PlayerPrefs.SetInt ("Level3", 0);
			PlayerPrefs.SetInt ("Level4", 0);
			PlayerPrefs.SetInt ("Level5", 0);
			PlayerPrefs.SetInt ("Level6", 0);
			PlayerPrefs.SetInt ("Level7", 0);
			PlayerPrefs.SetInt ("highScore", 0);
            PlayerPrefs.SetFloat("type", 0f);
            PlayerPrefs.SetFloat("sensitivity", 1.0f);
		} else {
			ResourcesScript.cheat = 1;
			ResourcesScript.resetCounter = 0;
			PlayerPrefs.SetInt ("highScore", ResourcesScript.highScore);
            PlayerPrefs.SetFloat("type", ResourcesScript.type);
            PlayerPrefs.SetFloat("sensitivity", ResourcesScript.sensitivity);
		}

        Destroy(GameObject.FindGameObjectWithTag("Music"));
		SceneManager.LoadScene (mainmenu);
	}

	public void MainMenu ()
	{
		SceneManager.LoadScene (mainmenu);
	}

	public void onHover ()
	{
		audiosource.clip = hover;
		audiosource.Play ();
	}
}
