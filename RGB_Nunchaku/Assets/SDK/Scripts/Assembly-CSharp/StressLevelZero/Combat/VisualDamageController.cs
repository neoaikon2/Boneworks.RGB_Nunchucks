using UnityEngine;

namespace StressLevelZero.Combat
{
	public class VisualDamageController : MonoBehaviour
	{
		public Renderer[] Renderers;
		[SerializeField]
		private DismembermentController dismemberment;
		public float meshScaleFactor;
		public float hitScaleFactor;
	}
}
