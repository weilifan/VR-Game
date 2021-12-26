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
         passwordDigitText.GetComponent<Text>().text = "The "+digitNumber+" digit of password is "+SelectPassword.realPassword[digitNumber-1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
