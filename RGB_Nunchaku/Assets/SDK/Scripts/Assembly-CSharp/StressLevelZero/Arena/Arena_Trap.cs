using UnityEngine;

namespace StressLevelZero.Arena
{
	public class Arena_Trap : MonoBehaviour
	{
		[SerializeField]
		private bool visDebug;
		[SerializeField]
		private Quaternion startRot;
		[SerializeField]
		private bool triggerTimeSlow;
		[SerializeField]
		private float secondaryReleaseWait;
		public GameObject secondaryObj;
	}
}
