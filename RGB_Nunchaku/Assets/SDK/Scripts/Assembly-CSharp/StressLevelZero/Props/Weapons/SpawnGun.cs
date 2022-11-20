using System;
using StressLevelZero.Data;
using UnityEngine;

namespace StressLevelZero.Props.Weapons
{
	public class SpawnGun : Gun
	{
		[Serializable]
		public struct Category
		{
			public string name;
			public SpawnableObject[] objects;
		}

		public Category[] categories;
		public LayerMask collisionLayers;
		public float effectiveRange;
		public bool wackySpinWhenUpsideDown;
		public SpawnableMasterListData masterList;
		public bool isDespawnMode;
		public GameObject laserPointerGameObject;
	}
}
