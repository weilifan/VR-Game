using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWeapon : MonoBehaviour
{
    //public GameObject[] weapons;//存放的武器
    public static List<GameObject> alweapons=new List<GameObject>();//实例化武器到集合里，集合的好处是集合长度是动态的。
    //private int i;//集合的下标值
	public static int weaponNumber = 0;
	//public GameObject magicToken;
	
	public void CollectToken()
    {
        weaponNumber++;
		//CollectableWeaponController collectableWeaponController = this.gameObject.GetComponent<CollectableWeaponController>();
		//AddWeapon(collectableWeaponController.weapon_to_add);
		DestroyImmediate(this.gameObject);
    }
	
	public static void AddWeapon(GameObject weapon_to_add)
    {
        alweapons.Add(weapon_to_add);
    }
}
