using PuppetMasta;
using UnityEngine;

namespace StressLevelZero.Zones
{
	public class ZoneAISettings : ZoneItem
	{
		public ZoneSpawner zoneSpawner;
		public BaseEnemyConfig baseConfig;
		public Transform homeTransform;
		public bool homeIsPost;
		public bool isAutoInvestigate;
		public bool isAutoAggro;
		public bool isSoundAggroWhenInSecondaryZone;
		public float investigateTimeout;
		public bool overrideRoam;
		public Vector2 roamXz;
		public float roamSpeed;
		public bool roamWanders;
	}
}
