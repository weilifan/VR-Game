using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWeapon : MonoBehaviour
{
    public static int weaponNumber = 0;
	public GameObject magicToken;
	
	public void CollectToken()
    {
        weaponNumber++;
		DestroyImmediate(magicToken);
    }
	
	// Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
