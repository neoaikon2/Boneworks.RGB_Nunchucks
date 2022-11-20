using System;
using UnityEngine;
using System.Collections.Generic;

namespace StressLevelZero.Combat
{
	[Serializable]
	public struct SubGibblets
	{
		public GameObject Gibblet;
		public GameObject[] OrginalObjects;
		public List<VisualDamageReceiver> HitReceivers;
		public bool DetachTreeIfDismembered;
		public int subID;
	}
}
