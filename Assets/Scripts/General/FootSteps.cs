using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour {

    [SerializeField]

    private AudioClip[] clips;

    private AudioSource audioSource;
    private bool running;

    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    
    }

    public void Update()
    {
        if (Input.GetAxis("Fire3") == 1)
        {
            running = true;
        }
        else
        {
            running = false;
        }
      
    }

    private void Step()
    {
        if (!running)
        {

            AudioClip clip = GetRandomClip();
            audioSource.PlayOneShot(clip);
            
        }
    }

    private void RunningStep()
    {
        if (running)
        {
            AudioClip clip2 = GetRandomClip();
            audioSource.PlayOneShot(clip2);
        }
    }

    private AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }



}
