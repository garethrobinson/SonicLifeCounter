using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    public BackgroundManager bgManager;
    public Sidebar sidebar;
    private List<Player> playerList = new List<Player>();

	// Use this for initialization
	void Start () {
        bgManager.OnFinishOpen += BackgroundOpenHandler;
        bgManager.OpenBG();
	}

    void BackgroundOpenHandler ( ) {
        sidebar.Show();
    }
	
}
