using UnityEngine;
using System.Collections.Generic;

namespace StressLevelZero.Data
{
	public class SpawnGunListData : ScriptableObject
	{
		[SerializeField]
		public List<SpawnableObject> items;
	}
}
