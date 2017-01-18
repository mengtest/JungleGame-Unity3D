using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {

	public GameObject zombie;
	void OnTriggerEnter( Collider other )
	{

        if (other.gameObject.tag == "Player")
        {
            Instantiate(zombie, transform.position, transform.rotation);
        }

	}

}
