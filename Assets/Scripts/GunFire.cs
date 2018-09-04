using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

    public float damage = 10.0f;
    public float range = 100.0f;
        
    public AudioSource gunSound;
    public AudioSource sudanHit;

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1 || Input.GetMouseButtonDown(0))
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                gunSound.Play();
                Shoot();
            }
        }
    }


    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.tag == "Sudan")
            {

                Destroy(hit.transform.gameObject);
                sudanHit.Play();

            }
        };
    }
}
