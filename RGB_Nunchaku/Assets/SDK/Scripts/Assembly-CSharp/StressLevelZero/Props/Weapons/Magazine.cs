using UnityEngine;
using StressLevelZero.Combat;
using StressLevelZero;
using StressLevelZero.Interaction;
using StressLevelZero.Player;

namespace StressLevelZero.Props.Weapons
{
	public class Magazine : MonoBehaviour
	{
		public MagazineData magazineData;
		public bool reloadOnEject;
		public SaveItem saveItem;
		public Grip grip;
		public Transform insertPointTransform;
		public InteractableHost interactableHost;
		public GameObject firstBullet;
		public GameObject secondBullet;
		public PlayerInventory parentInventory;
		public bool isMagazineInserted;
	}
}
