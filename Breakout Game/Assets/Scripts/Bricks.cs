using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour 
{

	public GameObject brickParticle;

	void OnCollisionEnter()
	{
		Instantiate (brickParticle, transform.position, Quaternion.identity);
		Debug.Log ("destroy");
		GM.instance.DestroyBrick ();
		Destroy (gameObject);
	}
}
