using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public virtual void HandleDeath()
    {
		Destroy(this.gameObject);
    }
}
