using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour {

	public float fullHealth = 100;
	public float currHealth;
	// Use this for initialization
	void Awake (){
		currHealth = fullHealth;
	}

	public void GetHurt (int damageAmount) {
		currHealth -= damageAmount;
        HealthBar.health = currHealth;
		if (currHealth <= 0) {
			KillPlayer ();
		}
	}

	public void KillPlayer(){
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
