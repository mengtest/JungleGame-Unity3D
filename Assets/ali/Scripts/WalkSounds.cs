using UnityEngine;
using System.Collections;

public class WalkSounds : MonoBehaviour {
    private AudioSource WalkAudio;

	// Use this for initialization
	void Awake () {
        WalkAudio = GetComponent<AudioSource>();
	}
   
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
             {
                 WalkAudio.Play(); 
             }
         
	}
}
