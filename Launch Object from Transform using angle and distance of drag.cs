using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	private bool chazHit;
	private Vector3 chazCurrentPosition;
	private Vector3 mouseDownPosition;
	private Vector3 mouseUpPosition;
	private float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//see if we are over our object, raycast from mouse to object
		if(Input.GetMouseButtonDown(0))
		{
			Debug.Log("Mouse Button Left Down"); //log message mouse button 0 (left) down.
			RaycastHit hit; //setup a return variable which contains the gameObject thats been hit.
			
			mouseDownPosition = Input.mousePosition;
			
			//do raycast
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			//if true we have a hit, check it's our object
			if(Physics.Raycast(ray, out hit, 50f))
			{
				//log which object is hit
				Debug.Log("Successfull HIT! " + hit.transform.tag.ToString());
				
				//if its our object react
				if(hit.transform.tag == "CHAZ")
				{
					chazHit = true; //take note, raycast has hit object
					chazCurrentPosition = transform.position; //store chaz current position
				}
			}
		}
		
		if(chazHit)
		{
			if(Input.GetMouseButtonUp(0))
			{
				Debug.Log("Mouse Button Left UP"); //log message mouse button 0 (left) UP.
				chazHit = false; //reset chaz has been hit, so not to keep executing if block

				mouseUpPosition = Input.mousePosition;
				
				Vector3 shootVector = (mouseDownPosition - mouseUpPosition).normalized; //This gets the direction
				
				//this applies the velocity, using the direction * 10% of the distance
				rigidbody.velocity = shootVector * (Vector3.Distance(mouseUpPosition, mouseDownPosition)*.1f);
				
				//elevation angle, 0 along the x axis 
				float angle = Vector3.Angle(shootVector, Vector3.right);
				Debug.Log(angle);
			}
		}
	}
}
