using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableGlow : MonoBehaviour
{
    public GameObject glow;
	public void Glow()
	{
		glow.SetActive(true);
	}
	
	public void StopGlow()
	{
		glow.SetActive(false);
	}
	
	// Start is called before the first frame update
    void Start()
    {
        glow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
