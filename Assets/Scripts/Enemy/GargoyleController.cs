using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleController : MonoBehaviour
{
    [Header("Gargoyle health")]
	[SerializeField] private float gargoyle_max_health;
	private Health gargoyle_health;
	
	void Start()
    {
		gargoyle_health = GetComponent<Health>();
		SetDefaultValues();
		
    }
	
	void SetDefaultValues()
	{
		gargoyle_health.Initialize(gargoyle_max_health);
	}

    void OnTriggerEnter(Collider other) {
        // 如果碰撞的是Boundary则返回
        if (other.tag == "Water")
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
