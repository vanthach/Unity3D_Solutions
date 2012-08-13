
		//see if we are over our object, raycast from mouse to object
		if(Input.GetMouseButtonDown(0))
		{
			Debug.Log("Mouse Button Left Down"); //log message mouse button 0 (left) down.
			RaycastHit hit; //setup a return variable which contains the gameObject thats been hit.
			
			//do raycast
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			//if true we have a hit, check it's our object
			if(Physics.Raycast(ray, out hit, 20f))
			{
				//log which object is hit
				Debug.Log("Successfull HIT! " + hit.transform.tag.ToString());
				
				//if its our object react
				if(hit.transform.tag == "CHAZ")
				{
					Debug.Log("We have hit CHAZ!");
				}
			}
		}