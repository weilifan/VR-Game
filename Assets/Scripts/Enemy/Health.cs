using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //health
    public float max_health;
    public float current_health;
	
	[SerializeField] Slider enemy_health_bar;
	
	[Header("Audio")]
	//be attacked audio
	public AudioSource attackedClip;


	void Update()
    {
		enemy_health_bar.value = (float)current_health/max_health;
    }
	
    public void Initialize(float max_health)
    {
        this.max_health = max_health;
    }
	
	public void TakeDamage(float damage)
    {
        attackedClip.Play();//Play sound
		
        float counted_damage = Mathf.Max(0, damage);
        current_health -= damage;

        if(current_health <= 0)
            Die();
    }

    private void Die()
    {
		Destroy(this.gameObject);
    }
}
