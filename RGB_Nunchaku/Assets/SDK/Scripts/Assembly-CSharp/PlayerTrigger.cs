using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
	[SerializeField]
	private UnityEvent TriggerEnterEvent;
	[SerializeField]
	private UnityEvent TriggerExitEvent;
}
