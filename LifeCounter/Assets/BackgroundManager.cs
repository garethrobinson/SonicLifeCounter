using UnityEngine;
using System.Collections;

public class BackgroundManager : MonoBehaviour {

    public RectTransform BlueBG;
    public RectTransform YellowBG;

    public System.Action OnFinishOpen;
    // Use this for initialization
    void Start () {
        OpenBG();
    }

    public void OpenBG ( ) {
        iTween.ValueTo( gameObject, iTween.Hash( "from", 0.0f, "to", -768.0f, "onupdatetarget", gameObject, "onupdate", "UpdateBlue", "time", 0.25f ) );
        iTween.ValueTo( gameObject, iTween.Hash( "from", 0.0f, "to", -1366.0f, "onupdatetarget", gameObject, "onupdate", "UpdateYellow", "time", 0.25f, "delay", 0.2f, "oncompletetarget", gameObject, "oncomplete", "FinishOpen" ) );
    }
	
    void UpdateBlue(float y ) {
        BlueBG.anchoredPosition = new Vector2( 0.0f, y );
    }

    void UpdateYellow ( float x ) {
        YellowBG.anchoredPosition = new Vector2( x, 0 );
    }
    void FinishOpen ( ) {
        if ( OnFinishOpen != null ) {
            OnFinishOpen();
        }
    }
}
