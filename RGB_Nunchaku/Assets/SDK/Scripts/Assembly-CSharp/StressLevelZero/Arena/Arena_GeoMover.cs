using UnityEngine;

namespace StressLevelZero.Arena
{
	public class Arena_GeoMover : MonoBehaviour
	{
		[SerializeField]
		private float moveUpDuration;
		[SerializeField]
		private float moveDownDuration;
		[SerializeField]
		private Quaternion startRot;
		[SerializeField]
		private Quaternion endRot;
		[SerializeField]
		private Vector3 startPos;
		[SerializeField]
		private Vector3 endPos;
		public bool isDynamic;
		public bool isUniqueFloor;
		public bool isRotater;
		public bool isOG_Floor;
		[SerializeField]
		private GameObject[] childObjects;
		public Arena_ObjectSpawner objectSpawner;
		public int spawnableIndex;
		public GameObject combinedMeshObj;
		public Color despawnColor;
	}
}
