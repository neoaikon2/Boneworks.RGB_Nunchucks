using UnityEngine;

namespace StressLevelZero.VFX
{
	public class ParticleSpread : MonoBehaviour
	{
		public enum Alignment
		{
			Surface = 0,
			Source = 1,
			Reflected = 2,
			Viewer = 3,
			SurfaceSourceBlend = 4,
		}

		public Alignment alignment;
		public float MinAngle;
		public float MaxAngle;
		public ParticleSystem TargetParticleSystem;
	}
}
