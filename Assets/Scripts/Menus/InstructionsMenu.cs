using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsMenu : MonoBehaviour
{
	public string settings;

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

	public void Settings ()
	{
		SceneManager.LoadScene (settings);
	}

	public void onHover ()
	{
		audiosource.clip = hover;
		audiosource.Play ();
	}
}