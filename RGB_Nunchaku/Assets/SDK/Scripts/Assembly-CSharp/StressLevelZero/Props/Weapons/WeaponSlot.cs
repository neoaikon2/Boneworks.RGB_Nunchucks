using UnityEngine;
using StressLevelZero.Interaction;
using UnityEngine.Events;

namespace StressLevelZero.Props.Weapons
{
	public class WeaponSlot : MonoBehaviour
	{
		public enum SlotType
		{
			SIDEARM = 1,
			PRIMARY = 2,
			SECONDARY = 4,
			HEAD = 8,
		}

		public SlotType slotType;
		public InteractableHost interactableHost;
		public MagazineSocket magazineSocket;
		public Grip grip;
		public UnityEvent onSlotInsert;
		public UnityEvent onSlotRemove;
	}
}
