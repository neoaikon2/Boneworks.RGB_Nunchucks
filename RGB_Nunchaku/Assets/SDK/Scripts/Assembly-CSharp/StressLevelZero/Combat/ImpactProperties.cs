using UnityEngine;

namespace StressLevelZero.Combat
{
	public class ImpactProperties : ImpactPropertiesVariables
	{
		[SerializeField]
		private Collider MyCollider;
		[SerializeField]
		public bool hasManager;
		[SerializeField]
		public bool ShowControls;
		[SerializeField]
		public ImpactPropertiesManager Manager;
	}
}
