using StressLevelZero.Data;
using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.Zones
{
	public class ZoneSpawner : ZoneItem
	{
		public enum modes
		{
			SINGLE = 0,
			EMITTER = 1,
		}

		public bool autoStart;
		public bool isSpawningAllowed;
		public SpawnableObject spawnObject;
		public modes mode;
		public int max;
		public int concurrentAlive;
		public int concurrentTotal;
		public bool isResetOnZoneEnable;
		public AudioClip[] spawnClip;
		public float frequency;
		public Vector3 spawnVelocity;
		public Vector3 spawnAngularVelocity;
		public float minSpawnAngularVelocity;
		public float maxSpawnAngularVelocity;
		public UnityEvent onActivate;
		public UnityEvent onDeactivate;
		public UnityEvent onSpawn;
	}
}
