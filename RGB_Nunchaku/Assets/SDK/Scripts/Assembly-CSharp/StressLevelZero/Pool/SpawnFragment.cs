using UnityEngine;
using StressLevelZero;
using StressLevelZero.SFX;

namespace StressLevelZero.Pool
{
	public class SpawnFragment : MonoBehaviour
	{
		public TextureArrayApplicator[] fragments;
		public Rigidbody[] rigidbodies;
		public ImpactSFX[] sfx;
	}
}
