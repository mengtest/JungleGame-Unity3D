using UnityEngine;
using System.Collections;

public class HealthBarEnemy : MonoBehaviour {
    private EnemyHealth eh;
    public GameObject enemy;
    public GameObject healthBar;
	// Use this for initialization
	void Awake () {
        if (enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
        }
        eh = enemy.GetComponent<EnemyHealth>();
	}

	
	// Update is called once per frame
	void Update () {
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(eh.currHealth/100, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
        // currHealth/100 -- > Current Enemy health Devid by FullHealth
	}
}
