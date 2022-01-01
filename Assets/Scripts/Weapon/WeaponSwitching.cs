using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwitching : MonoBehaviour
{
    
	[SerializeField] InputActionReference controllerActionGrip;
	
	private int selectedWeapon = 1;
	private int weaponNumber;
	private int previousSelectedWeapon;
	
    void Start()
    {
		foreach (Transform weapon in transform)
		{
			weapon.gameObject.SetActive(false);
		}
    }

    void Update()
    {
		weaponNumber = CollectWeapon.weaponNumber;
		
		controllerActionGrip.action.performed += swiftWeapon;
    }
	
	private void swiftWeapon(InputAction.CallbackContext obj)
	{
		previousSelectedWeapon = selectedWeapon;
		
		if(selectedWeapon >= transform.childCount - 1)
			selectedWeapon = 0;
		else
			selectedWeapon++;
		
		if(previousSelectedWeapon != selectedWeapon)
		{
			SelectWeapon();
		}
	}
	
	void SelectWeapon()
	{
		int i = 0;
		foreach (Transform weapon in transform)
		{
			if(i < weaponNumber)
			{
				if(i == selectedWeapon)
					weapon.gameObject.SetActive(true);
				else
					weapon.gameObject.SetActive(false);
			}
			else
			{
				weapon.gameObject.SetActive(false);
			}
			i++;
		}
	}
}
