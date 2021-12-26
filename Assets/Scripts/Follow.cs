using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;//Bind the character's Transform
    public float Up = 0f;//The vertical height parameters of the camera and the target
    public float Away = 3f;//Parameter of the horizontal distance between the camera and the target
    public float smooth = 2f;//Position smooth movement interpolation parameter value
    public float camDepthSmooth = 20f;

    void Update()
    {
        // The mouse axis controls the distance of the camera
        if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth * Time.deltaTime;
        }
    }

    void LateUpdate()
    {
        //Calculate the position of the camera
        Vector3 disPos = target.position + Vector3.up * Up - target.forward * Away;
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        //Camera angle
		Vector3 pos = target.position;
		pos.y += 1f;
        transform.LookAt(pos);
    }
}
