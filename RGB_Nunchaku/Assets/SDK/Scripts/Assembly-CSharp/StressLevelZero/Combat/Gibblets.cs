using System;
using UnityEngine;

namespace StressLevelZero.Combat
{
	[Serializable]
	public struct Gibblets
	{
		public GameObject Gibblet;
		public GameObject[] OrginalObjects;
		public bool InstantKill;
		public float health;
		public SubGibblets[] subGibblets;
		public int ID;
	}
}
