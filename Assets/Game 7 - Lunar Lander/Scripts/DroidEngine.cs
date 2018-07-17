using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroidEngine : MonoBehaviour {

    public ParticleSystem droidExhaust1;
    public AudioClip launchSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            droidExhaust1.Play();
            AudioSource.PlayClipAtPoint(launchSound, Camera.main.transform.position+ new Vector3(0.0f, 0.0f, 30.0f));
        }
        else
        {
            droidExhaust1.Stop();
        }
        

    }

}
