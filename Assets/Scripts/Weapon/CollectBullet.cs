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
		DestroyImmediate(bullet);
    }
	
	public static void ConsumeBullet()
    {
        bulletNumber--;
    }
	
	void Update()
    {
        MainUIManager.instance.UpdateBulletCountText(bulletNumber, 10);
    }
}
