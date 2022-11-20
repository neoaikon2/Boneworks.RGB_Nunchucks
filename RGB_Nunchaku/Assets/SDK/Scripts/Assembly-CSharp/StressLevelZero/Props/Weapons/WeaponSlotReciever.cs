using StressLevelZero.Interaction;
using UnityEngine;

namespace StressLevelZero.Props.Weapons
{
	public class WeaponSlotReciever : InteractionReciever
	{
		public float priority;
		public WeaponSlot.SlotType slotType;
		public bool isFlipped;
		public Vector3 primaryAxis;
		public bool useOffset;
		[SerializeField]
		private bool enableUpdateVolume;
		[SerializeField]
		private CapsuleCollider _interactableCol;
		[SerializeField]
		private Transform _t1Tran;
		public Vector3 t1PlaneOffset;
	}
}
