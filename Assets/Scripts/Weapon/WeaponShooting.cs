using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponShooting : MonoBehaviour
{
	[SerializeField] InputActionReference controllerActionTrigger;
	public float speed = 50;
	public GameObject magicToken;
	public GameObject bullet;
	public Transform Sliencer;
	public AudioSource gunSound;
	
	
	private void Awake()
	{
		controllerActionTrigger.action.performed += TriggerPress;
		
		controllerActionTrigger.action.canceled += TriggerEnd;
		
		
		
		//GameObject rootObj = GameObject.Find("Right Hand Model");
		//magicToken =  rootObj.transform.Find("pfb_FireTotem").gameObject;
	}	
	
    void Start()
    {
        //magicToken.SetActive(false);
    }

    private void TriggerPress(InputAction.CallbackContext obj)
	{
		if(CollectBullet.bulletNumber > 0)
		{
			if(getActive(magicToken)){
				Fire();
				CollectBullet.ConsumeBullet();
			}
		}
	}
	
	private void TriggerEnd(InputAction.CallbackContext obj)
	{
		
	}
	
	
	public bool getActive(GameObject go)
    {
        if (go)
        {
            return go.activeInHierarchy;
        }
		return false;
    }
	
	public void Fire()
	{
		GameObject spawnBullet = Instantiate(bullet, Sliencer.position, Sliencer.rotation);
		spawnBullet.GetComponent<Rigidbody>().velocity = speed * Sliencer.forward;
		gunSound.Play();
		//Destroy(spawnBullet, 2);
	}
}
