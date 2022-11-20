using UnityEngine;
using TMPro;
using StressLevelZero.Interaction;

namespace StressLevelZero
{
	public class SaveSpot : MonoBehaviour
	{
		public TextMeshPro text;
		public Transform spawnPoint;
		public SaveItem saveItem;
		public SaveItemCollector itemCollector;
		public Transform playerSpawnPoint;
		public Grip leftGrip;
		public Grip rightGrip;
		[SerializeField]
		private GameObject Picture;
		[SerializeField]
		private Renderer SaveStatusRing;
		[SerializeField]
		private GameObject Flash;
		[SerializeField]
		private AudioSource ChargeAudio;
		[SerializeField]
		private AudioClip ChargeClip;
		[SerializeField]
		private AudioClip FlashClip;
		public TextMeshPro txt_DisplayAction;
	}
}
