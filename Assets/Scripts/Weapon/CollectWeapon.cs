using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWeapon : MonoBehaviour
{
	public static int weaponNumber = 0;
	
	public void CollectToken()
    {
        weaponNumber++;
		DestroyImmediate(this.gameObject);
    }
}
