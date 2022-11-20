using StressLevelZero.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Props.Weapons
{
	public class HandWeaponSlotReciever : HandInteractionReciever
	{
		public SaveState.BodySlot saveBodySlotType;
		public float priority;
		public WeaponSlot.SlotType slotType;
		public bool isFlipped;
		public Vector3 primaryAxis;
		public UnityEvent OnSlotDrop;
		public UnityEvent OnSlotExit;
		public UnityEvent OnSlotEnter;
		public bool useOffset;
		[SerializeField]
		private bool enableUpdateVolume;
		[SerializeField]
		private CapsuleCollider _insertCol;
		[SerializeField]
		private CapsuleCollider _grabCol;
		[SerializeField]
		private Transform _t1Tran;
		public Vector3 t1PlaneOffset;
	}
}
