using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables needed for health
    [Header("Health and Shield")]
    [SerializeField] private float max_health = 10f;
    private PlayerHealth player_health;
	
	// Start is called before the first frame update
    void Start()
    {
        player_health = GetComponent<PlayerHealth>();
		player_health.Initialize(max_health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
