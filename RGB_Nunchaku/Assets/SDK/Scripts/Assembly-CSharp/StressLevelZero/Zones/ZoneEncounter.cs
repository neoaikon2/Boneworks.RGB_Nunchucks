using System;
using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Zones
{
	public class ZoneEncounter : ZoneItem
	{
		[Serializable]
		public class SpawnGroup
		{
			public uint concurrent;
			public uint maxSpawn;
			public float initialGroupDelay;
			public float spawnInterval;
			public ZoneSpawner[] spawners;
			public bool hostileGroup;
		}

		public enum SpawnOrder
		{
			PARALLEL = 0,
		}

		public SpawnOrder spawnOrder;
		public SpawnGroup[] spawnGroups;
		public AudioClip encounterMusic;
		public float volume;
		public bool loop;
		public float fadeInTime;
		public float fadeOutTime;
		public UnityEvent OnComplete;
	}
}
