using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System;

public class SelectPassword : MonoBehaviour
{
    //public Button[] passwordButtons;
	public GameObject passwordIncorrect;
	
	public static string realPassword = GenerateRandomCode(4);
	
	public static string userEnteredPassword = "";
	
	// Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//当每个按钮被按下，纪录用户输入的密码
	public void Select(int levelIndex)//int levelIndex
	{
		userEnteredPassword = string.Concat(userEnteredPassword,levelIndex.ToString());
		Debug.Log("当前密码是："+userEnteredPassword);
		Debug.Log("正确密码是："+realPassword);
	}
	
	//当确认按钮被按下，比较用户输入的密码和正确密码
	public void ComparePassword()
	{
		if(realPassword == userEnteredPassword)
		{
			Debug.Log("密码正确");
			passwordIncorrect.SetActive(false);
		}
		else
		{
			passwordIncorrect.SetActive(true);
			userEnteredPassword = "";
		}
	}
	
	public static string GenerateRandomCode(int length)
	{
		var result = new StringBuilder();
		for (var i = 0; i < length; i++)
		{
			var r = new System.Random(Guid.NewGuid().GetHashCode());
			result.Append(r.Next(1, 6));
		}
		return result.ToString();
	}
}
