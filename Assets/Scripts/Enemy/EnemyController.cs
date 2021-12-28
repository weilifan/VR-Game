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

    /*private	void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Health health;
            health=other.gameObject.GetComponent<Health>();
            health.TakeDamage(1);
        }
    }*/
	
	void OnTriggerEnter(Collider other) {
        // 如果碰撞的是Boundary则返回
        if (other.tag == "Fire")
		{
			Health health;
            health=this.gameObject.GetComponent<Health>();
            health.TakeDamage(1);
			
			
			//  实例化爆炸特效
			//Instantiate(explosion, transform.position, transform.rotation);
			//isHealthValueLessThanZero = Health.isHealthValueLessThanZero();
			
			Destroy(other.gameObject);  // 摧毁子弹
			
		}
    }
}
