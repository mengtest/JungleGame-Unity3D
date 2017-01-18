using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
    public int shotDamage = 20;
    public float reloadTime = .2f;
    public float range = 50f;

    private float timer;
    private Ray rayShot;
    private RaycastHit hit;

    private LineRenderer shotLine;
    private AudioSource ShotAudio;
    private Light shotLight;
    private float shotEffect = .2f;
    // Use this for initialization
    void Awake()
    {
        shotLine = GetComponent<LineRenderer>();
        ShotAudio = GetComponent<AudioSource>();
        shotLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (Input.GetButton("Fire2") && timer >= reloadTime)
        {
            Shoot();
        }
        if (timer >= reloadTime * shotEffect)
        {
            DisableEffect();
        }
    }
    void Shoot()
    {
        timer = 0f;

        ShotAudio.Play();
        shotLine.enabled = true;
        shotLight.enabled = true;
        shotLine.SetPosition(0, transform.position);
        rayShot.origin = transform.position;
        rayShot.direction = transform.forward;

        if (Physics.Raycast(rayShot, out hit, range))
        {
            EnemyHealth eh = hit.collider.GetComponent<EnemyHealth>();
            if (eh != null)
            {
                eh.GetHurt(shotDamage);
            }
            shotLine.SetPosition(1, hit.point);
        }
        else
        {
            shotLine.SetPosition(1, rayShot.origin + range * rayShot.direction);
        }
    }
    void DisableEffect()
    {
        shotLight.enabled = false;
        shotLine.enabled = false;
    }
}