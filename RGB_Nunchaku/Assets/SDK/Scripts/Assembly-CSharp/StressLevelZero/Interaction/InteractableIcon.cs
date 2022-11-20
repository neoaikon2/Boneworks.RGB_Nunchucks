using UnityEngine;
using StressLevelZero;

namespace StressLevelZero.Interaction
{
	public class InteractableIcon : MonoBehaviour
	{
		public Transform targetCenter;
		public GripIconType gripIconType;
		[SerializeField]
		private GameObject iconObj;
		public int hoverCount;
		public int farHoverCount;
		[SerializeField]
		private bool LocalOverride;
		[SerializeField]
		private Texture IconTex;
		[SerializeField]
		private float IconSize;
		[SerializeField]
		private float AnimationDuration;
	}
}
