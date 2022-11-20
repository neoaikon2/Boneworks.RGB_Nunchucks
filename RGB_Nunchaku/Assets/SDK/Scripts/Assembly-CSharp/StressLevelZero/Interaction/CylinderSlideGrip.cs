using StressLevelZero.Props.Weapons;
using UnityEngine;

namespace StressLevelZero.Interaction
{
	public class CylinderSlideGrip : CylinderGrip
	{
		public Gun gun;
		public float slideDistance;
		public bool isManualSlideMovement;
		public Vector3 slideDirection;
		public Vector3 upDirection;
	}
}
