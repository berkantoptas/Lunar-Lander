using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {




    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Camera.main.pixelWidth / 2 - 50, Camera.main.pixelHeight / 2 - 10, 100, 30), "Play Game"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Camera.main.pixelWidth / 2 - 50, Camera.main.pixelHeight / 2 + 40, 100, 30), "Quit Game"))
        {
            Application.Quit();
        }
    }
}