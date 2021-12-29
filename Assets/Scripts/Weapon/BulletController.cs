using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody rbody;
	private Vector3 move_direction;
    private float move_force;

    public float lifeTime = 10f;
	public bool isCollided = false;
	
    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {	
		if (!isCollided)
			Move();
        Destroy(this.gameObject, lifeTime);
    }
	
	//子弹的移动
    public void Move()
    {
        transform.position += move_force * move_direction * Time.deltaTime; //first way

        //rbody.AddForce(move_direction*move_force);
    }

    public void SetMoveParam(Vector3 move_direction, float move_force)
    {
        this.move_direction = move_direction;
        this.move_force = move_force;
    }
}
