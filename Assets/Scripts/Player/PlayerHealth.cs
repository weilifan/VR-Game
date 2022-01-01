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
	
	[Header("Lost Canvas")]
	public GameObject lostCanvas;

	public void Initialize(float max_health)
    {
        this.max_health = max_health;
    }
	
	public void TakeDamage(float damage)
    {
        attackedClip.Play();//Play the sound effect of the player being hurt
		
        current_health -= damage;

		MainUIManager.instance.UpdateHealthBar(current_health, max_health);


        if(current_health <= 0)
            Die();
    }

    private void Die()
    {
        lostCanvas.SetActive(true);
    }
}
