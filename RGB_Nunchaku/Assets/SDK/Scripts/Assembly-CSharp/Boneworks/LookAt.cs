using UnityEngine;

namespace Boneworks
{
	public class LookAt : MonoBehaviour
	{
		public Transform head;
		public Vector3 lookAtTargetPosition;
		public float lookAtCoolTime;
		public float lookAtHeatTime;
		public bool looking;
		public Animator animator;
	}
}
