using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System;

public class SelectPassword : MonoBehaviour
{
	[Header("Prompt text for incorrect password")]
	public GameObject passwordIncorrect;
	
	[Header("User entered password text")]
	public Text userEnteredPasswordText;
	
	[Header("Door opening sound")]	
	public AudioSource doorOpenedClip;
	
	
	public static string realPassword = GenerateRandomCode(4);
	public static string userEnteredPassword = "";
	
	void Update()
    {
		userEnteredPasswordText.text = "Please enter password: " + userEnteredPassword;
    }
	
	//When each button is pressed, the password entered by the user is recorded
	public void Select(int passwordIndex)
	{
		userEnteredPassword = string.Concat(userEnteredPassword,passwordIndex.ToString());
		Debug.Log("当前密码是："+userEnteredPassword);
		Debug.Log("正确密码是："+realPassword);
	}
	
	//When the confirm button is pressed, compare the password entered by the user with the correct password
	public void ComparePassword()
	{
		if(realPassword == userEnteredPassword)
		{
			PlayDoorAnimation.PlayAnimation();
			doorOpenedClip.Play();//Play sound
			Destroy(this.gameObject, 1f);
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
