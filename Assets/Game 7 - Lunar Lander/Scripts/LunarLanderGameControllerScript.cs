using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LunarLanderGameControllerScript : MonoBehaviour {

    private bool isGameOver;
    private bool levelResult = false;

    private int isSucceed = 0;

    private GameObject lunarLander;

    private float speed;
    public static int coin = 0;

    void Start()
    {
        lunarLander = GameObject.FindGameObjectWithTag("Player");
        Physics.gravity = new Vector3(0, -3.5F, 0);
    }

    void Update()
    {
        speed = lunarLander.GetComponent<Rigidbody>().velocity.magnitude;
    }

    public void LevelFailed()
    {
        isGameOver = true;
    }

    public void LevelSucceeded()
    {
        isGameOver = true;
        levelResult = true;
        isSucceed = 1;
    }

    public void CoinCollect()
    {
        coin++;
    }

    public int GetCoin()
    {
        return coin;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), "Speed : " + speed.ToString("0.0"));
        GUI.Label(new Rect(10, 30, 300, 20), "Coins Collected : " + coin);

        if (isGameOver)
        {

            if (levelResult)
            {
                //GUI.Label(new Rect(Camera.main.pixelWidth / 2 - 40, Camera.main.pixelHeight / 2 - 65, 180, 30), "Congratulations!");
                Application.LoadLevel(2);
            }
            else
            {
                GUI.Label(new Rect(Camera.main.pixelWidth / 2 - 40, Camera.main.pixelHeight / 2 - 65, 180, 30), "You have failed...");
            }

            if(isSucceed!=1)
            {
                if (GUI.Button(new Rect(Camera.main.pixelWidth / 2 - 40, Camera.main.pixelHeight / 2 - 15, 80, 30), "New Game"))
                {
                    int scene = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(scene, LoadSceneMode.Single);
                }
            }
        }

    }



}
