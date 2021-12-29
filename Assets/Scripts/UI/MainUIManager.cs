using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
	public static MainUIManager instance{ get; private set;}
	
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
	
	public Image healthBar;
	public Text bulletCountText;

    public void UpdateHealthBar(float curAmount, float maxAmount)
    {
        healthBar.fillAmount = curAmount / maxAmount;
    }
	
	public void UpdateBulletCountText(int curAmount, int maxAmount)
    {
        bulletCountText.text = curAmount.ToString() + " / " + maxAmount.ToString();
    }
}
