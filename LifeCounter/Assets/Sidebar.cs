using UnityEngine;
using System.Collections;

public enum WindowState {
    NONE,
    CLOSED, 
    OPEN,
    CLOSING,
    OPENING,
}

public class Sidebar : MonoBehaviour {
    private RectTransform rectTransform;
    private WindowState state;
    public void Show ( ) {
        iTween.ValueTo( gameObject, iTween.Hash( "from", 0.0f, "to", 110f, "onupdatetarget", gameObject, "onupdate", "Move", "time", 0.15f ) );
        state = WindowState.CLOSED;
    }
    public void Open ( ) {
        iTween.ValueTo( gameObject, iTween.Hash( "from", rectTransform.anchoredPosition.x, "to", 240f, "onupdatetarget", gameObject, "onupdate", "Move", "time", 0.15f, "oncompletetarget", gameObject, "oncomplete", "OnOpened" ) );
    }
    public void Close ( ) {
        iTween.ValueTo( gameObject, iTween.Hash( "from", rectTransform.anchoredPosition.x, "to", 110.0f, "onupdatetarget", gameObject, "onupdate", "Move", "time", 0.15f, "oncompletetarget", gameObject, "oncomplete", "OnClosed" ) );
    }
    public void Toggle ( ) {
        if(state == WindowState.OPEN || state == WindowState.OPENING ) {
            Close();
        }
        else if ( state == WindowState.CLOSED || state == WindowState.CLOSING ) {
            Open();
        }
    }

    void OnOpened ( ) {
        state = WindowState.OPEN;
    }
    void OnClosed ( ) {
        state = WindowState.CLOSED;
    }


    void Move(float x ) {
        rectTransform.anchoredPosition = new Vector2( x, 0.0f );
    }

    void Awake ( ) {
        rectTransform = GetComponent<RectTransform>();
    }
    
}
