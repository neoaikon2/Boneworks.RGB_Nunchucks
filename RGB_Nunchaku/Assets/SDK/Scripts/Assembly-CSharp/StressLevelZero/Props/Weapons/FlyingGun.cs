using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.SFX;

namespace StressLevelZero.Props.Weapons
{
	public class FlyingGun : MonoBehaviour
	{
		public bool noClip;
		public float maxSpeed;
		public Grip triggerGrip;
		public Transform firePoint;
		public AnimationCurve speedCurve;
		public GravGunSFX sfx;
		public Transform ringA;
		public Transform ringB;
		public Transform ringC;
	}
}
