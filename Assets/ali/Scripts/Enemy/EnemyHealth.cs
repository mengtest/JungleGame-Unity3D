using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    public float fullHealth = 100;
    public float currHealth;
    public int scoreValue = 10;
   

    private bool isDead;



 
    void Awake()
    {
        currHealth = fullHealth;
    }

    public void GetHurt(int damageAmount)
    {

        if (isDead)
            return;

        currHealth -= damageAmount;
        if (currHealth <= 0)
        {
            KillEnemy();
        }
    }

    public void KillEnemy()
    {
        isDead = true;
        Destroy(gameObject, 1f);
        //score
        Score.score += scoreValue;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
