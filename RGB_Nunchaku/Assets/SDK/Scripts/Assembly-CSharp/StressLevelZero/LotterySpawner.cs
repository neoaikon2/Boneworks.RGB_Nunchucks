using UnityEngine;
using System;
using StressLevelZero.Data;

namespace StressLevelZero
{
	public class LotterySpawner : MonoBehaviour
	{
		[Serializable]
		public struct LotteryItem
		{
			public SpawnableObject data;
			public float weight;
		}

		public LotteryItem[] lotteryItems;
	}
}
