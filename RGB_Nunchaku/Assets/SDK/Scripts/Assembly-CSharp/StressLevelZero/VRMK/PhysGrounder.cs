using UnityEngine;
using UnityEngine.Audio;

namespace StressLevelZero.VRMK
{
	public class PhysGrounder : MonoBehaviour
	{
		public PhysBody physBody;
		public bool isGrounded;
		public bool ungroundedThisFrame;
		public bool ladderCheck;
		public Vector3 groundNormal;
		public Vector3 _totalImpulse;
		public float totalMass;
		public AudioClip feetSkidSlime;
		public AudioClip[] highFallClips;
		public AudioMixerGroup mixerGroup;
		public float highFallVolumeMult;
		public PhysicMaterial[] slimeMats;
	}
}
