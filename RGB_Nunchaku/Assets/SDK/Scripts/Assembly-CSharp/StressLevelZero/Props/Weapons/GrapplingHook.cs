using UnityEngine;

namespace StressLevelZero.Props.Weapons
{
	public class GrapplingHook : Gun
	{
		[SerializeField]
		private LayerMask collisionLayers;
		[SerializeField]
		private float effectiveRange;
		[SerializeField]
		private float spring;
		[SerializeField]
		private GameObject Hook;
		[SerializeField]
		private Transform AnchorPoint;
		public bool firedAndHooked;
		public ConfigurableJoint hitjoint;
		public GameObject hookie;
	}
}
