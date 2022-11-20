using UnityEngine;

public class TriggerLasers : MonoBehaviour
{
	[SerializeField]
	private LayerMask LayerFilter;
	[SerializeField]
	private UnityEventTrigger OnTriggerEnterEvent;
	[SerializeField]
	private UnityEventTrigger OnTriggerExitEvent;
	public GameObject obj_SpecificTrigger;
	public bool OneTimeUse;
	public bool onlyTriggerOnPlayer;
}
