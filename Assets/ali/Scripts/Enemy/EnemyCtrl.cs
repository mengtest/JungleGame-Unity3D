using UnityEngine;
using System.Collections;

public class EnemyCtrl : MonoBehaviour {

	Transform PlayerTransform;
	NavMeshAgent nma;
    public int FlagEnter = 0;

	// Use this for initialization
	void Awake () {
		PlayerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		nma = GetComponent<NavMeshAgent> ();
        

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FlagEnter = 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
 
           FlagEnter = 0;

    }
	// Update is called once per frame
	void Update () {
        
		nma.SetDestination (PlayerTransform.position);
	}
}
