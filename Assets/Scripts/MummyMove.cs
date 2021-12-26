using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyMove : MonoBehaviour
{
    private Transform mummy;
    public float speed = 2f;
	
	public float changeDirectionTime = 2f;//the time duration to change direction
	public bool isVertical;//moving is vertical or not
	private float changeTimer;//the timer of changing direction
	private Vector3 moveDirection;//the current moving direction
	
	// Start is called before the first frame update
    void Start()
    {
        mummy = this.transform;
		moveDirection = isVertical ? Vector3.up : Vector3.right;//if moving is vertical, then set the direction to up, if moving is horizontal, then set the direction to right
		changeTimer = changeDirectionTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		changeTimer -= Time.deltaTime;

		if(changeTimer <= 0)
		{
			moveDirection *= -1;
			changeTimer = changeDirectionTime;
		}
		
		transform.position += moveDirection * Time.deltaTime * speed;
    }
}
