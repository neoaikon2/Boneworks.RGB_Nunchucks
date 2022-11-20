using UnityEngine;
using StressLevelZero.Data;
using UnityEngine.Audio;

namespace StressLevelZero.Arena
{
	public class Arena_Launcher : MonoBehaviour
	{
		[SerializeField]
		private SpawnableObject hoiPoiObject;
		[SerializeField]
		private GameObject hoiPoiPrefab;
		[SerializeField]
		private Transform aimTarget;
		[SerializeField]
		private Transform confettiAimTarget;
		[SerializeField]
		private float fireForce;
		[SerializeField]
		private Transform parentRotater;
		public Vector3 arenaCenterPosition;
		[SerializeField]
		private Arena_SpawnEnemies spawner;
		public AudioMixerGroup audioGroup;
		public AudioClip hoiPoiClip;
		public AudioClip confettiClip;
	}
}
