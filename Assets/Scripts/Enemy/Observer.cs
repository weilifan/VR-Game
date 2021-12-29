using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
	bool m_IsPlayerInRange;
	
	void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            m_IsPlayerInRange = true;
			Debug.Log("碰到了玩家");
        }
		
		Debug.Log("碰到了");
    }
	
	void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            m_IsPlayerInRange = false;
        }
    }
	
	void Update ()
    {
        if (m_IsPlayerInRange)
        {
            Debug.Log("在if里碰到了玩家");
			Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;
            
            if (Physics.Raycast (ray, out raycastHit))
            {
                Debug.Log("在射线if里碰到了玩家");
				//if (raycastHit.collider.transform == player)
                //{
                    PlayerHealth health;
					health=player.gameObject.GetComponent<PlayerHealth>();
					health.TakeDamage(1);
                //}
            }
        }
    }
}
