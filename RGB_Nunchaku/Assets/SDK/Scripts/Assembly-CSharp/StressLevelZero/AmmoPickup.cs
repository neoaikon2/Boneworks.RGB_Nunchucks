using UnityEngine;
using StressLevelZero.Combat;

namespace StressLevelZero
{
	public class AmmoPickup : MonoBehaviour
	{
		public Weight ammoWeight;
		public int ammoCount;
		public AudioClip collectAudioClip;
		public SaveItem saveItem;
	}
}
