using UnityEngine;

public class GunTwo : MonoBehaviour
{
	public Transform firingSpot;
	public GameObject bullFab;
	public int maxBull = 3;
	private int bullCount;
	
	
	
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Shot();
			
		}
		
		if (maxBull > 0)
		{
			bullCount = 0;
		}
		
		//if (Input.GetButtonDown("Fire1") && bullCount < maxBull)
		//{
		//	bullCount++;
		//}

		
	}

	void Shot()
	{
		Instantiate(bullFab, firingSpot.position, firingSpot.rotation);
		
	}
}
