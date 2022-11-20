using UnityEngine;

namespace StressLevelZero.Environment
{
	public class Nail : MonoBehaviour
	{
		public Rigidbody rb;
		public Rigidbody connectedRb;
		public ConfigurableJoint joint;
		public Transform nailTran;
		public float breakforce;
	}
}
