using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour {
	
	public Transform target; //place target object in IDE
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.LookAt(target); //quick simple way but turns instantly
		
		//how to rotate an object overtime to rotate to look at a target object over time
		Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0f);
	}
}
