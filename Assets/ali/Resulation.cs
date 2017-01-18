using UnityEngine;
using System.Collections;

public class Resulation : MonoBehaviour {

    public float targetRatio = 4f / 3f; //The aspect ratio you did for the game.
    void Start()
    {
        Camera cam = GetComponent<Camera>();
        cam.aspect = targetRatio;
    }
    // Update is called once per frame
    void Update () {
	
	}
}
