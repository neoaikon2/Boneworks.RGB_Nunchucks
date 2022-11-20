using System;
using UnityEngine;

namespace StressLevelZero.Combat
{
	[Serializable]
	public struct GibletEllipsoid
	{
		public Transform Ellipsoid;
		public GameObject[] InternalGiblets;
	}
}
