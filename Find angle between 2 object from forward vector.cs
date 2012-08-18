			Vector3 forward = transform.forward; 
			Vector3 targetDirection = target.position - this.transform.position;
			float angle = Vector3.Angle(targetDirection, forward);
			if(angle<3)
			{
				Debug.Log("You've been damaged!!!!");
				DoDamage(); //adjust player health
				TurretAttack(); //animate turret firing
			}