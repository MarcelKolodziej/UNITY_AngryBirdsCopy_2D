using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


	public GameObject deathEffect;

	public float health = 4f;

	public static int enemyCounter = 0;

	void Start ()
	{
		enemyCounter++;
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		
		if (colInfo.relativeVelocity.magnitude > health) // velocity of 1 object compare to 2 // object on x,y .magnitude take 2 values 
														//compare and give 1 raport. 
		{
			Die();
		}														 
	}

	void Die() 
	{
		enemyCounter--;
		if (enemyCounter <= 0) {
			Debug.Log ("STAGE COMPLETED");
		}
		Instantiate (deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
