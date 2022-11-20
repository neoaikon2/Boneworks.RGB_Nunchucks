using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.Props.Weapons;

namespace StressLevelZero
{
	public class HealthPickup : MonoBehaviour
	{
		public float healthAmount;
		public AudioClip collectAudioClip;
		[SerializeField]
		private InteractableHost host;
		[SerializeField]
		private Collider _col;
		[SerializeField]
		private WeaponSlot wSlot;
		[SerializeField]
		private MeshRenderer _rend;
		[SerializeField]
		private GameObject parentObj;
		public bool isCollectable;
	}
}
