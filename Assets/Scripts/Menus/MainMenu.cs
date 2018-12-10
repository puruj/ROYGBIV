using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Manages player input through the main menu
*/
public class MainMenu : MonoBehaviour
{
    public string levelSelect;

    public string arcade;

    public string settings;

    public AudioSource audiosource;

    public AudioClip hover;

    public AudioClip click;

    void Awake()
    {
        Cursor.visible = true;
        audiosource = GetComponent<AudioSource>();
    }

    void Start()
    {
        audiosource.clip = click;
        audiosource.Play();
    }

    public void LevelSelect()
    {
        ResourcesScript.mode = 0;
        SceneManager.LoadScene(levelSelect);
    }

    public void Arcade()
    {
        ResourcesScript.mode = 1;
        SceneManager.LoadScene(arcade);
    }

    public void Settings()
    {
        SceneManager.LoadScene(settings);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void onHover()
    {
        audiosource.clip = hover;
        audiosource.Play();
    }
}