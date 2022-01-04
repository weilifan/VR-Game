using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPasswordDigit : MonoBehaviour
{
    public GameObject passwordDigitText;
	public int digitNumber;
	
	// Start is called before the first frame update
    void Start()
    {
         passwordDigitText.GetComponent<Text>().text = "The digit "+digitNumber+" of password is "+SelectPassword.realPassword[digitNumber-1];
    }
}
