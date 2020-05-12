﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

public float fireRate = 3;

float timeUntilFire = 0;

public Transform firePoint;
public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetButtonDown("Fire1") && Time.time > timeUntilFire)
      {
        timeUntilFire = Time.time + 1 / fireRate;
        Shoot();
      }
    }

    void Shoot()
    {
      Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

}
