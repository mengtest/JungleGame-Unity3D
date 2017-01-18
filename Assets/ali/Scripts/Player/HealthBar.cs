using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public static float health;
    public Text healthText;

    void Awake()
    {
        healthText = GetComponent<Text>();
        health = 100;
    }

    // Use this for initialization
    void LateUpdate()
    {
        healthText.text = "Health : " + health;
    }

}
