using System;
using UnityEngine;

namespace StressLevelZero.Data
{
	[Serializable]
	public class LootTableData : ScriptableObject
	{
		[SerializeField]
		public LootItem[] items;
	}
}
