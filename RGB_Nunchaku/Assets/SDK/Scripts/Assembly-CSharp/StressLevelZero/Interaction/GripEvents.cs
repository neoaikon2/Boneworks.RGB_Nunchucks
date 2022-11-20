using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Interaction
{
	public class GripEvents : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent AttachedEvent;
		[SerializeField]
		private UnityEvent DetachEvent;
		[SerializeField]
		private UnityEvent PrimaryButtonEventDown;
		[SerializeField]
		private UnityEvent PrimaryButtonEvent;
		[SerializeField]
		private UnityEvent PrimaryButtonEventUp;
	}
}
