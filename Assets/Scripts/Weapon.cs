using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("Shooting") == 1)
        {
            //this.gameObject.SetActive(true);
            this.gameObject.GetComponent<Weapon>().enabled = true;
        }
        else
        {
            bool shooting = this.gameObject.GetComponent<Weapon>().isActiveAndEnabled;

            Debug.Log(shooting);

            int shots = 0;

            if (shooting == true)
            {
                shots = 1;
            }
            else
            {
                shots = 0;
            }

            PlayerPrefs.SetInt("Shooting", shots);
            Debug.Log(shots);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
