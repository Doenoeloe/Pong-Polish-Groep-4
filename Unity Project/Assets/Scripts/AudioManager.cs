using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Declares the audio sources
    AudioSource sfx;
    AudioSource music;

    // Declares the audio clips
    AudioClip bound;
    AudioClip win;

    // Declares the random pitch value
    float randomPitch = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Adds the audio source components
        sfx = gameObject.AddComponent<AudioSource>();
        music = gameObject.AddComponent<AudioSource>();

        // Turns off play on awake
        sfx.playOnAwake = false;

        // Loads the audio clips
        bound = Resources.Load<AudioClip>("Audio/Bound");
        win = Resources.Load<AudioClip>("Audio/Score");
    }

    // Update is called once per frame
    void Update()
    {
        // Sets the random pitch between 0.9 and 1.1
        randomPitch = Random.Range(0.9f, 1.1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sfx.pitch = randomPitch;
        sfx.clip = bound;
        sfx.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sfx.pitch = randomPitch;
        sfx.clip = win;
        sfx.Play();
    }

}
