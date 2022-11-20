using UnityEngine;
using StressLevelZero.Data;
using System.Collections.Generic;
using StressLevelZero.Pool;
using StressLevelZero.Props;

namespace StressLevelZero.Arena
{
	public class Arena_ObjectSpawner : MonoBehaviour
	{
		public bool isDestroying;
		public SpawnableObject destBoxSpawnable;
		public GameObject destBoxPrefab;
		public SpawnableObject boxFragmentSpawnable;
		public List<Arena_BoxGroup> boxForest_BoxGroupList;
		public List<GameObject> spawnedBoxList;
		public List<Poolee> boxPooleeList;
		public List<ObjectDestructable> destBoxList;
		public SpawnableObject woodPlankDestObject;
		public SpawnableObject plankFragmentSpawnable;
		public GameObject woodPlankPrefab;
		public Transform[] pitPlankSpawns;
		public List<ObjectDestructable> destPlankList;
		public List<Poolee> plankPooleeList;
	}
}
