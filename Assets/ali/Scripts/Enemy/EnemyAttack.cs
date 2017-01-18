using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public GameObject player;
    public GameObject enemy;
	private PlayerHealth ph;
    
    //
    private EnemyHealth eh;
	public float timeToAttack = 0.50f;
	public int atkAmount = 10;
	private bool inRange=false;
	private float timer;

	// Use this for initialization
	void Awake () 
    {
		if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        ph = player.GetComponent<PlayerHealth>();
        if (enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
        }
        //
        eh=enemy.GetComponent<EnemyHealth>();
	}
	
	// Update is called once per frame


   
    void Update() 
    {
     
		timer += Time.deltaTime;
        if (timer >= timeToAttack && inRange && eh.currHealth > 0)
        {
			Attack ();
		}
	
	}

	void Attack()
	{
		if (ph.currHealth > 0)
			ph.GetHurt (atkAmount);
		timer = 0f;
	
	}

	void OnTriggerEnter( Collider other )//sphere colider
	{

        if (other.gameObject == player)
        {
            inRange = true;
      
        }
	}

	void OnTriggerExit( Collider other )
	{

        if (other.gameObject == player)
        {
            inRange = false;
         
        }
	}

}
