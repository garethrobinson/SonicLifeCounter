using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
    public static AudioManager Instance;
    
    private AudioSource source;

    public void PlayOneShot(AudioClip clip ) {
        source.PlayOneShot( clip );
    }


    void Awake ( ) {
        Instance = this;
        source = GetComponent<AudioSource>();
    }
}
