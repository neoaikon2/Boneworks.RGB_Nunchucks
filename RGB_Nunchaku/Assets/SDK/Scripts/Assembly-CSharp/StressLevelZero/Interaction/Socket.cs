using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class Socket : MonoBehaviour
	{
		public Grip proxyGrip;
		public float endDistance;
		public float influenceRadius;
		public InteractableHost host;
		public Transform cutoffDirection;
	}
}
