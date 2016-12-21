using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    public BackgroundManager    bgManager;
    public Sidebar              sidebar;
    public GameObject           playerPrefab    = null;

    private List<Player>        playerList      = new List<Player>();

    public void CreatePlayer ( ) {
        GameObject newPlayer = GameObject.Instantiate(playerPrefab);
        playerList.Add( newPlayer.GetComponent<Player>() );
    }

    private void ArrangePlayers ( ) {

    }

    // Use this for initialization
    void Start () {
        bgManager.OnFinishOpen += BackgroundOpenHandler;
        bgManager.OpenBG();
	}

    void BackgroundOpenHandler ( ) {
        sidebar.Show();
    }
	
}
