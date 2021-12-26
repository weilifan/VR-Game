using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTokenAction : MonoBehaviour
{
    public float speed = 50;
	public GameObject bullet;
	public GameObject collectableMagicToken;
	public Transform Sliencer;
	public AudioSource gunSound;
	
	public GameObject hand;
	
	public void Fire()
	{
		GameObject spawnBullet = Instantiate(bullet, Sliencer.position, Sliencer.rotation);
		spawnBullet.GetComponent<Rigidbody>().velocity = speed * Sliencer.forward;
		gunSound.Play();
		//Destroy(spawnBullet, 2);
	}
	
	public void Collect()
	{     
        
		//GameObject transformObj = GameObject.Find("pfb_FireTotem_Hand");
		//GameObject transformObj=  hand.transform.GetChild(2).gameObject;
        //transformObj.SetActive(true);
		//collectableMagicToken.SetActive(false);
		Debug.Log("能碰"); 
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
