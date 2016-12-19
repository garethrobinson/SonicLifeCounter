using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
    public PlayerInfo playerInfo = null;
    public Text lifeText;

    public void UpdateLifeTotal(int delta ) {
        playerInfo.life += delta;
        lifeText.text = playerInfo.life.ToString();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
