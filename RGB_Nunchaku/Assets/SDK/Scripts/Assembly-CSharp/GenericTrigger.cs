using UnityEngine;

public class GenericTrigger : MonoBehaviour
{
	[SerializeField]
	private LayerMask LayerFilter;
	[SerializeField]
	private UnityEventTrigger OnTriggerEnterEvent;
	[SerializeField]
	private UnityEventTrigger OnTriggerExitEvent;
}
