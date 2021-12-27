using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public static int healthValue;
	public static int healthValueFull;
	public static AudioSource enemyHittenSound;
	public int healthValueDefine = 10;
	public AudioSource enemyHittenSoundDefine;
	public AudioSource enemyDeadDefine;
	public static AudioSource enemyDead;
	public Slider sliderDefine;
	
	public static Slider slider;
	
	public static void DecreaseHealthValue()
    {
        
		healthValue--;
		slider.value = (float)healthValue/healthValueFull;//通过改变value的值来改变血条长度。
		if(isHealthValueLessThanZero() == true)
		{
			enemyDead.Play();
			//Destroy(this.gameObject); // 摧毁敌人
			
		}else
			enemyHittenSound.Play();
    }
	
	public static bool isHealthValueLessThanZero()
    {
        if(healthValue <= 0)
			return true;
		else
			return false;
    }
	
	// Start is called before the first frame update
    void Start()
    {
        healthValue = healthValueDefine;
		enemyHittenSound = enemyHittenSoundDefine;
		enemyDead = enemyDeadDefine;
		healthValueFull = healthValueDefine;
		slider = sliderDefine;
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("敌人健康"+healthValue);
    }
}
