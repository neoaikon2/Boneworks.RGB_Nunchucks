using UnityEngine;
using StressLevelZero.Data;

namespace StressLevelZero.Interaction
{
	public class SpawnGrip : MonoBehaviour
	{
		public float priority;
		public SpawnableObject spawnObject;
		[SerializeField]
		private bool enableUpdateVolume;
		[SerializeField]
		private CapsuleCollider _interactableCol;
		[SerializeField]
		private Transform _t1Tran;
		public Vector3 t1PlaneOffset;
	}
}
