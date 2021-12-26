using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableAutoRotate : MonoBehaviour
{
    [Tooltip("Angular velocity in degrees per seconds")]
    public float degPerSec = 60.0f;

    [Tooltip("Rotation axis")]
    public Vector3 rotAxis = Vector3.up;
	
	// Start is called before the first frame update
    void Start()
    {
        rotAxis.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotAxis, degPerSec * Time.deltaTime);
    }
}
