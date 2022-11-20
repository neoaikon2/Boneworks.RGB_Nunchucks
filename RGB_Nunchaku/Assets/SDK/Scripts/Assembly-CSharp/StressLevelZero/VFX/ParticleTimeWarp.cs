using UnityEngine;

namespace StressLevelZero.VFX
{
	public class ParticleTimeWarp : MonoBehaviour
	{
		[SerializeField]
		private float TrailMotionBlurFrames;
		[SerializeField]
		private float MaxParticleLifetime;
		[SerializeField]
		private ParticleSystem PS;
	}
}
