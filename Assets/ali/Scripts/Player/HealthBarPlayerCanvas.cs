using UnityEngine;
using System.Collections;

public class HealthBarPlayerCanvas : MonoBehaviour {

    private PlayerHealth eh;
    public GameObject player;
    public GameObject healthBar;
    // Use this for initialization
    void Awake()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        eh = player.GetComponent<PlayerHealth>();
 
    }


    // Update is called once per frame
    void Update()
    {
        healthBar.transform.localScale = new Vector3(Mathf.Clamp((eh.currHealth/100), 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
        // currHealth/100 -- > Current Enemy health Devid by FullHealth
    }
}
