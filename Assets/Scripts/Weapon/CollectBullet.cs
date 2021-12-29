using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBullet : MonoBehaviour
{
    public static int bulletNumber = 0;
	public GameObject bullet;
	
	public void Collect()
    {
        bulletNumber++;
		
		MainUIManager.instance.UpdateBulletCountText(bulletNumber, 10);
		
		DestroyImmediate(bullet);
    }
	
	public static void ConsumeBullet()
    {
        bulletNumber--;
    }
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
