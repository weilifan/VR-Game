using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRHandController : MonoBehaviour
{
    [SerializeField] InputActionReference controllerActionGrip;
	[SerializeField] InputActionReference controllerActionTrigger;
	
	private Animator handAnimator;
	
	private void Awake()
	{
		handAnimator = GetComponent<Animator>();
		
		controllerActionGrip.action.performed += GripPress;
		controllerActionTrigger.action.performed += TriggerPress;
		
		controllerActionGrip.action.canceled += GripEnd;
		controllerActionTrigger.action.canceled += TriggerEnd;
	}	
	
	private void GripPress(InputAction.CallbackContext obj)
	{
		handAnimator.SetFloat("Grip", obj.ReadValue<float>());
	}
	
	private void GripEnd(InputAction.CallbackContext obj)
	{
		handAnimator.SetFloat("Grip", 0);
	}
	
	private void TriggerPress(InputAction.CallbackContext obj)
	{
		handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
	}
	
	private void TriggerEnd(InputAction.CallbackContext obj)
	{
		handAnimator.SetFloat("Trigger", 0);
	}
	

}
