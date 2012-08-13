using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	private float speed = 3.0f;
	public Transform cratePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Fire1"))
		{
			Transform crate = Instantiate(cratePrefab, Camera.main.transform.position, Quaternion.identity) as Transform;
			crate.rigidbody.AddForce(transform.forward * 2000);
		}
	}
}
