using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwitching : MonoBehaviour
{
    
	[SerializeField] InputActionReference controllerActionGrip;
	
	public GameObject collectableFireTotem;
	public CollectWeapon collectWeaponScript;
	
	public int selectedWeapon = 0;
	public int weaponNumber;
	
    void Start()
    {
        SelectWeapon();
    }

    void Update()
    {
		//int previousSelectedWeapon = selectedWeapon;
		
		weaponNumber = CollectWeapon.weaponNumber;//collectableFireTotem.GetComponent<CollectWeapon>().weaponNumber;
		
		controllerActionGrip.action.performed += swiftWeapon;
		
		
        /*if (Input.GetAxis("Mouse ScrollWhell") > 0f)
		{
			if(selectedWeapon >= transform.childCount - 1)
				selectedWeapon = 0;
			else
				selectedWeapon++;
		}*/
		/*if (Input.GetAxis("Mouse ScrollWhell") < 0f)
		{
			if(selectedWeapon <= 0)
				selectedWeapon = transform.childCount - 1;
			else
				selectedWeapon--;
		}
		
		if(previousSelectedWeapon != selectedWeapon)
		{
			SelectWeapon();
		}*/
    }
	
	private void swiftWeapon(InputAction.CallbackContext obj)
	{
		int previousSelectedWeapon = selectedWeapon;
		if(selectedWeapon >= transform.childCount - 1)
				selectedWeapon = 0;
		else
			selectedWeapon++;
		
		if(previousSelectedWeapon != selectedWeapon)
		{
			SelectWeapon();
		}
		
		Debug.Log("换武器"); 
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
		Debug.Log("当前武器数"+weaponNumber);
	}
}
