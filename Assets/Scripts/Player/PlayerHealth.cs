using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //health
    public float max_health;
    public float current_health;
	
	[Header("Audio")]
	//be attacked audio
	public AudioSource attackedClip;
	
	void Awake()
    {
        
    }

	public void Initialize(float max_health)
    {
        this.max_health = max_health;
    }
	
	public void TakeDamage(float damage)
    {
        attackedClip.Play();//播放音效
		//the damage received after shield breaks
        float counted_damage = Mathf.Max(0, damage);
        current_health -= damage;

		MainUIManager.instance.UpdateHealthBar(current_health, max_health);


        if(current_health <= 0)
            Die();
    }

    private void Die()
    {
        
    }
}
