using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDoorAnimation : MonoBehaviour
{
    public static Animator anis;
	
	// Start is called before the first frame update
    void Start()
    {
        anis = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public static void PlayAnimation()
	{
		anis.Play("DoorOpen");
	}
}
