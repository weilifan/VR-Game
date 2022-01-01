using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody rbody;
	private Vector3 move_direction;
    private float move_force;

    public float lifeTime = 10f;
	
    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {	
		transform.position += move_force * move_direction * Time.deltaTime; //The movement of the bullet
        Destroy(this.gameObject, lifeTime);
    }

    public void SetMoveParam(Vector3 move_direction, float move_force)
    {
        this.move_direction = move_direction;
        this.move_force = move_force;
    }
}
