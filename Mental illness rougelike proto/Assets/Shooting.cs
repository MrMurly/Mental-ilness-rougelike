using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{


	public Transform shooterPos;
	public Transform bulletToShoot;

	[HideInInspector]
	public bool flipped;

	public float fireRate = 0.3f;

	private float timer;
    // Update is called once per frame
    public void shoot()
    {
        if(Input.GetAxisRaw("Fire1") != 0)
		{
			if (timer <= 0)
			{
				Instantiate(bulletToShoot, shooterPos.position, Quaternion.identity);
				timer = fireRate;
			}
			else
			{
				timer -= Time.deltaTime;
			}
		}
    }
}
