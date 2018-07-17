using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour {

    private GUIStyle guiStyle = new GUIStyle();

    // Use this for initialization
    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        guiStyle.fontSize = 50;
        guiStyle.normal.textColor = Color.white;

        GUI.Label(new Rect(Camera.main.pixelWidth / 2 -250, Camera.main.pixelHeight / 2 - 65, 180, 30), "Coins Collected : " + LunarLanderGameControllerScript.coin, guiStyle);

        if (GUI.Button(new Rect(Camera.main.pixelWidth / 2 - 50, Camera.main.pixelHeight / 2 + 40, 100, 30), "Main Menu"))
        {
            Application.LoadLevel(0);
        }

        //GUI.Label(new Rect(10, 30, 300, 40), "Coins Collected : " + LunarLanderGameControllerScript.coin);

        

    }

}
