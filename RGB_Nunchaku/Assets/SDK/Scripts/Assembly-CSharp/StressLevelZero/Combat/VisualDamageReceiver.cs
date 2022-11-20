using UnityEngine;
using PuppetMasta;

namespace StressLevelZero.Combat
{
	public class VisualDamageReceiver : MonoBehaviour
	{
		[SerializeField]
		private Vector3 orgpos;
		[SerializeField]
		private Quaternion orgrot;
		[SerializeField]
		private Vector3 orgScale;
		public Transform bone;
		[SerializeField]
		private VisualDamageController visualDamageController;
		[SerializeField]
		public GibletEllipsoid[] gibletEllipsoid;
		public Arena_EnemyReference arenaEnemyRef;
		public PuppetMaster puppet;
	}
}
