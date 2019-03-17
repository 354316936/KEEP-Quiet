using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Script : MonoBehaviour
{
    public AudioClip SoundPlay;
    public float Volume;
    AudioSource audio;
    public bool Played = false;

    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!Played)
        {
            if(other.tag=="Player")
            {
                gameObject.active = true;
                audio.PlayOneShot(SoundPlay, Volume);
                Played = true;
            }
          
        }
    }
}
