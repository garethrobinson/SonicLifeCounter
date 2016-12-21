using UnityEngine;
using System.Collections;

public class ButtonAudio : MonoBehaviour {
    public AudioClip sfx;
    UnityEngine.UI.Button butt;
	// Use this for initialization
	void Start () {
        butt = GetComponent<UnityEngine.UI.Button>();
        butt.onClick.AddListener( PlaySFX );
	}
	
	void PlaySFX ( ) {
        AudioManager.Instance.PlayOneShot( sfx );
    }
}
