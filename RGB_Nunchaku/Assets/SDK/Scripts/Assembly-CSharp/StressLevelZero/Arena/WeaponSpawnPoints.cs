using UnityEngine;
using UnityEngine.Audio;
using StressLevelZero.Interaction;

namespace StressLevelZero.Arena
{
	public class WeaponSpawnPoints : MonoBehaviour
	{
		public bool isOpen;
		public AudioMixerGroup audioGroup;
		public AudioClip spawnClip;
		public GameObject crateTopHalfObj;
		[SerializeField]
		private Transform weaponSpawn;
		[SerializeField]
		private Transform magSpawn;
		[SerializeField]
		private DoorControl doorControl;
		[SerializeField]
		private Grip[] grips;
	}
}
