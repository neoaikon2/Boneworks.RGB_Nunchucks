using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Props
{
	public class CoreBombReciever : MonoBehaviour
	{
		public Color activeColor;
		public Color deactiveColor;
		public MeshRenderer meshRenderer;
		public Transform jointTarget;
		public SphereCollider sphereCollider;
		public Rigidbody rb;
		public bool hasCore;
		public AnimationCurve forcePercentageFalloff;
		public UnityEvent OnCoreAttached;
	}
}
