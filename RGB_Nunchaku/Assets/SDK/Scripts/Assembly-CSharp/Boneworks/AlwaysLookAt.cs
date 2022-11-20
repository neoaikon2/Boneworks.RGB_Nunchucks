using StressLevelZero.Zones;
using UnityEngine;

namespace Boneworks
{
	public class AlwaysLookAt : ZoneItem
	{
		public Transform local;
		public Transform target;
		public bool isPhysics;
		public ConfigurableJoint jnt_Rotator;
	}
}
