using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

	[Header("Enemy health")]
	[SerializeField] private float enemy_max_health;
	private Health enemy_health;
	
	void Start()
    {
		enemy_health = GetComponent<Health>();
		SetDefaultValues();
    }
	
	void SetDefaultValues()
	{
		enemy_health.Initialize(enemy_max_health);
	}
	
	void OnTriggerEnter(Collider other) {
        // If it collides with Fire, the mummy’s health value is reduced by one
        if (other.tag == "Fire")
		{
			Health health;
            health=this.gameObject.GetComponent<Health>();
            health.TakeDamage(1);
			
			Destroy(other.gameObject);  // Destroy the bullet
			
		}
    }
}
