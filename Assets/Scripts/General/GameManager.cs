using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Holds the game manager model
*/
public class GameManager : MonoBehaviour
{
    public GameObject shield;

    public Material body;

    private bool shieldActive;

    public GameObject miniMap;

    public GameObject pauseScreen;

    public GameObject winScreen;

    public GameObject lossScreen;

    private AudioSource audioSource;

    public AudioClip hit;

    public AudioClip collect;

    public AudioClip drop;

    public AudioClip win;

    public AudioClip lose;

    public AudioClip pause;

    public Text highScoreText;

    public Text scoreText;

    public IUnityService UnityService;

    private int highScore;

    private int score;
    public bool collided;

    // 0 for full game, 1 for arcade
    private int mode = ResourcesScript.mode;

    // Starting number of lives given per level
    private int health = 1;

    // Maintains the order in which the spheres must be tagged in
    private int sequence = 0;

    // Holds the current active scene
    private Scene scene;

    void Awake()
    {
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        Cursor.visible = false;
        audioSource = GetComponent<AudioSource>();
        pauseScreen.SetActive(false);
        lossScreen.SetActive(false);
        winScreen.SetActive(false); //sets all the different in game menus inactive
        scene = SceneManager.GetActiveScene();
        ResourcesScript.level = scene.name; // load scene
        if (UnityService == null)
            UnityService = new UnityService(); //create an instance of the interface
    }

    void Start()
    {
        if (mode == 1)
        {
            highScore = PlayerPrefs.GetInt("highScore");
            highScoreText.text = highScore.ToString();
            score = 0;
            scoreText.text = score.ToString(); //sets it into arcade mode
        }

        else
        {
            shield.SetActive(false); //shield initially off
            shieldActive = false;
            body.color = Color.white;
        }
    }

    private void Update()
    {
        if (mode == 0)
        {
            shield.transform.Rotate(0, 30 * Time.deltaTime, 0); //rotate shield
        }

        //checks if p or m is pressed to pause the game and get rid of the minimap
        //respectively

        if (UnityService.GetKeyDown("p") == true)
        {
            if (pauseScreen.activeInHierarchy == true)
                pauseScreen.SetActive(false);
            else
                pauseScreen.SetActive(true);

            Pause();
        }

        if (UnityService.GetKeyDown("m") == true)
        {
            if (miniMap.activeInHierarchy == true)
                miniMap.SetActive(false);
            else
                miniMap.SetActive(true);
        }

        // If player dies
        if (health <= 0)
        {
            Lose();
        }
    }

    void PlaySound(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();

        //plays whatever sound gets sent in
    }

    /*
     * Function checks if ball hit is in the correct sequence 
     */

    void CorrectTag()
    {
        sequence++;

        if (mode == 1)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    void Pause() //function to pause game
    {
        // Pause only if win and loss screen are inactive
        if (!winScreen.activeInHierarchy && !lossScreen.activeInHierarchy)
        {
            PlaySound(pause);
            if (Time.timeScale == 1)
            {
                Cursor.visible = true;

                Time.timeScale = 0;
            }
            else
            {
                Cursor.visible = false;

                Time.timeScale = 1;
            }
        }
    }

    void Win()
    {
        if (!winScreen.activeInHierarchy && !lossScreen.activeInHierarchy)
        {
            Cursor.visible = true;
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Lose()
    {
        if (!winScreen.activeInHierarchy && !lossScreen.activeInHierarchy)
        {
            PlaySound(lose);
            Cursor.visible = true;
            lossScreen.SetActive(true);

            if (mode == 1)
            {
                if (score > highScore)
                {
                    highScore = score;
                    PlayerPrefs.SetInt("highScore", highScore);
                    highScoreText.text = highScore.ToString();
                }
            }
            Time.timeScale = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Death"))
        {
            health = 0;
        }
    }

    /*
     * Function checks if correct ball is hit, kills player if not
     * Provides shield after 4th ball hit
     */

    void OnCollisionEnter(Collision other)
    {
        // If player touches anything but the spheres
        if (other.gameObject.CompareTag("Untagged"))
        {
            // Do nothing
        }
        else if (other.gameObject.CompareTag("Shield")) //if shield is collected
        {
            PlaySound(collect); //play sound
            shield.SetActive(false); //disappear 
            shieldActive = true; //shield in effect
            body.color = Color.green;
        }
        else if (sequence == 0 && other.gameObject.CompareTag("Red"))
        {
            PlaySound(hit); //play sound
            CorrectTag();
        }
        else if (sequence == 1 && other.gameObject.CompareTag("Orange"))
        {
            PlaySound(hit); //play sound
            CorrectTag();
        }
        else if (sequence == 2 && other.gameObject.CompareTag("Yellow"))
        {
            PlaySound(hit); //play sound
            CorrectTag();
        }
        else if (sequence == 3 && other.gameObject.CompareTag("Green")) //shield collectable appears after you tag green sphere
        {
            CorrectTag();
            PlaySound(hit); //play sound

            if (mode == 0)
            { //regular mode
                shield.SetActive(true); //activate shield collectable 
            }
        }
        else if (sequence == 4 && other.gameObject.CompareTag("Blue"))
        {
            PlaySound(hit); //play sound
            CorrectTag();
        }
        else if (sequence == 5 && other.gameObject.CompareTag("Indigo"))
        {
            PlaySound(hit); //play sound
            CorrectTag();
        }
        else if (sequence == 6 && other.gameObject.CompareTag("Violet"))
        {
            PlaySound(win);
            if (mode == 0)
            {
                Win();
            }
            else
            {
                CorrectTag();
                sequence = 0;
            }
        }
        else if (other.gameObject.CompareTag("Death")) //if fall into lava or fall off map
        {
            health = 0; //immediate death
        }
        else
        {
            if (shieldActive == false)
            { //if no shield on
                health--; //decrease health
            }
            else
            {
                PlaySound(drop); //play sound
                shieldActive = false;
                body.color = Color.white;
            }
        }
    }
}