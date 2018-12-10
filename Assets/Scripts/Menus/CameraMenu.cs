using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraMenu : MonoBehaviour
{
    public string settings;

    public Slider typeSlider;

    public Slider sensitivitySlider;

    public Text sensitivityText;

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

        if ((!PlayerPrefs.HasKey("type")) || (PlayerPrefs.GetFloat("type") <= 0f))
        {
            PlayerPrefs.SetFloat("type", 0f);
        }

        if ((!PlayerPrefs.HasKey("sensitivity")) || Mathf.Abs(PlayerPrefs.GetFloat("sensitivity")) < 0.5f)
        {
            PlayerPrefs.SetFloat("sensitivity", 1f);
        }

        sensitivitySlider.value = Mathf.Abs(PlayerPrefs.GetFloat("sensitivity"));
        typeSlider.value = PlayerPrefs.GetFloat("type");
    }

    public void Settings()
    {
        SceneManager.LoadScene(settings);
    }

    public void typeChange()
    {
        float type = typeSlider.value;

        ResourcesScript.type = type;
        PlayerPrefs.SetFloat("type", type);

        if (type == 2f)
        {
            sensitivitySlider.interactable = false;
        }
        else
        {
            sensitivitySlider.interactable = true;

            float sensitivity = sensitivitySlider.value;

            if (type == 0f)
            {
                PlayerPrefs.SetFloat("sensitivity", Mathf.Abs(sensitivity));
                ResourcesScript.sensitivity = Mathf.Abs(sensitivity);
            }
            else
            {
                PlayerPrefs.SetFloat("sensitivity", -Mathf.Abs(sensitivity));
                ResourcesScript.sensitivity = -Mathf.Abs(sensitivity);
            }
        }
    }

    public void sensitivityChange()
    {
        float sensitivity = sensitivitySlider.value;
        sensitivityText.text = sensitivity.ToString("F1");

        if (ResourcesScript.type == 0f)
        {
            PlayerPrefs.SetFloat("sensitivity", Mathf.Abs(sensitivity));
            ResourcesScript.sensitivity = Mathf.Abs(sensitivity);
        }
        else if (ResourcesScript.type == 1f)
        {
            PlayerPrefs.SetFloat("sensitivity", -Mathf.Abs(sensitivity));
            ResourcesScript.sensitivity = -Mathf.Abs(sensitivity);
        }
    }

    public void onHover()
    {
        audiosource.clip = hover;
        audiosource.Play();
    }
}