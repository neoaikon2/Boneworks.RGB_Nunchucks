using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class CylinderElectronicGrip : CylinderGrip
	{
		public ElectricInteractionVolume interactionVolume;
		public CylinderElectronicGrip BodyGrip;
		public CylinderElectronicGrip HandleGrip;
		public Transform powerSourceTransform;
		public Transform insertTransform;
		public Transform ejectTransform;
		[SerializeField]
		private PowerSourceType m_currentType;
	}
}
