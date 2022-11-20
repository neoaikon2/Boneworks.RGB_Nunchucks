using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class InteractableHost : MonoBehaviour
	{
		public InteractableHostManager manager;
		public bool ignoreBodyOnGrab;
		public bool isStatic;
		public bool hasRigidbody;
	}
}
