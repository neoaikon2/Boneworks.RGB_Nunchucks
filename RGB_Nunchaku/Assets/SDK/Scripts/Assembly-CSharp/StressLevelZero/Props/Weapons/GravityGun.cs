using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.VFX;

namespace StressLevelZero.Props.Weapons
{
	public class GravityGun : MonoBehaviour
	{
		public Grip triggerGrip;
		public Transform firePoint;
		public GravityManipulatorJob gravityManipulator;
		public QuadLine quadline;
		public GameObject blastVFXObject;
	}
}
