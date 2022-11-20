using UnityEngine;
using StressLevelZero.Data;
using StressLevelZero.Interaction;
using UnityEngine.Audio;
using StressLevelZero.Arena;

namespace StressLevelZero.Props.Tools
{
	public class SpawnCapsule : MonoBehaviour
	{
		public SpawnableObject spawnObject;
		public Grip triggerGrip;
		public InteractableHost host;
		[SerializeField]
		private AudioSource source;
		[SerializeField]
		private AudioMixerGroup outputMixer;
		[SerializeField]
		private AudioClip[] clickSound;
		[SerializeField]
		private AudioClip[] beepSound;
		[SerializeField]
		private AudioClip[] explodeSound;
		[SerializeField]
		private AudioClip[] whooshSound;
		[SerializeField]
		private Transform Button;
		[SerializeField]
		private Transform ButtonTargetPos;
		public float maxDistFromCenter;
		public Arena_SpawnEnemies arenaSpawner;
		public SphereCollider expandCollider;
		public float finalExpandRadius;
	}
}
