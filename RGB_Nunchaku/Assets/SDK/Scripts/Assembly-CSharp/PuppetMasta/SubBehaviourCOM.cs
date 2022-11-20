using System;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		public enum Mode
		{
			FeetCentroid = 0,
			CenterOfPressure = 1,
		}

		public Mode mode;
		public float velocityDamper;
		public float velocityLerpSpeed;
		public float velocityMax;
		public float centerOfPressureSpeed;
		public Vector3 offset;
		public bool[] groundContacts;
		public Vector3[] groundContactPoints;
	}
}
