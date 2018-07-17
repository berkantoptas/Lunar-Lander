using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LanderScript : MonoBehaviour {

    private LunarLanderGameControllerScript gameController;



	// Use this for initialization
	void Start () {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<LunarLanderGameControllerScript>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            //GetComponent<Rigidbody>().AddForce(transform.up * -5.0f);
            GetComponent<Rigidbody>().AddForce(0.0f, 10.0f, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(new Vector3(0.0f, 0.0f, -1.0f));
            //transform.Translate(0.1f, 0.0f, 0.0f);
            transform.Translate(-0.2f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f));
            //transform.Translate(-0.1f, 0.0f, 0.0f);
            transform.Translate(0.2f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f));
            //transform.Translate(0.0f, 0.0f, -0.1f);
            transform.Translate(0.0f, -0.2f, 0.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
            //transform.Translate(0.0f, 0.0f, 0.1f);
            transform.Translate(0.0f, 0.2f, 0.0f);
        }

        /*
        if (GetComponent<Rigidbody>().IsSleeping())
        {
            gameController.LevelSucceeded();
            enabled = false;
        }
        */

    }
    
    void OnCollisionEnter(Collision collision)
    {
        float angle = Vector3.Dot(transform.up, Vector3.up);
        angle = Mathf.Acos(angle);

        if (collision.gameObject.tag == "Landing")
        {
            gameController.LevelSucceeded();
            enabled = false;
        }

        if (collision.gameObject.tag == "Coin")
        {
            gameController.CoinCollect();
            Destroy(collision.gameObject);
            //enabled = false;
        }

        //if (angle > 1.0f || collision.relativeVelocity.magnitude > 2.0f || collision.gameObject.tag == "Moon")
        if (collision.gameObject.tag == "Moon")
            {
            gameController.LevelFailed();
            enabled = false;
        }

        if (collision.gameObject.tag == "Meteorite")
        {
            gameController.LevelFailed();
            enabled = false;
        }


    }
    
}
