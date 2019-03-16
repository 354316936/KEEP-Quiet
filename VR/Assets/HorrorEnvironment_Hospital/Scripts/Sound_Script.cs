using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Script : MonoBehaviour
{
    public AudioClip SoundPlay;
    public float Volume;
    AudioSource audio;
    public bool Played = false;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!Played)
        {
            audio.PlayOneShot(SoundPlay, Volume);
            Played = true;
        }
    }
}
