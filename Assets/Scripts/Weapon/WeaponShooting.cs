using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponShooting : MonoBehaviour
{
	[SerializeField] InputActionReference controllerActionTrigger;
	public float force = 7;
	
	[Header("Fire Magic Token")]
	public GameObject magicToken;
	public BulletController fireBullet;
	
	[Header("Water Magic Token")]
	public GameObject waterMagicToken;
	public BulletController waterBullet;
	
	[Header("Sliencer and Sound")]
	public Transform Sliencer;
	public AudioSource gunSound;
	
	
	private void Awake()
	{
		controllerActionTrigger.action.performed += TriggerPress;
	}	

	//Check which magic token is being used
    private void TriggerPress(InputAction.CallbackContext obj)
	{
		if(CollectBullet.bulletNumber > 0)
		{
			if(getActive(magicToken)){
				Fire();
				CollectBullet.ConsumeBullet();
			}
			if(getActive(waterMagicToken)){
				Water();
				CollectBullet.ConsumeBullet();
			}
		}
	}
	
	//Check which magic token is being activated in weapon holder
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
		BulletController spawnBullet = Instantiate(fireBullet, Sliencer.position, Quaternion.identity);
		spawnBullet.SetMoveParam(Sliencer.forward, force);
		gunSound.Play();
	}
	
	public void Water()
	{
		BulletController spawnBullet = Instantiate(waterBullet, Sliencer.position, Quaternion.identity);
		spawnBullet.SetMoveParam(Sliencer.forward, force);
		gunSound.Play();
	}
}
