using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class FuseInteractionVolume : InteractionVolume
	{
		public Transform targetPos;
		public Collider[] recieverColliders;
		[SerializeField]
		private float m_FuseBlowoutCap;
	}
}
