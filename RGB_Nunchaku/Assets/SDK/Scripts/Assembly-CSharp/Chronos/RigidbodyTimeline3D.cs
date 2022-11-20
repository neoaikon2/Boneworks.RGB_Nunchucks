using UnityEngine;
using System;

namespace Chronos
{
	public class RigidbodyTimeline3D : RigidbodyTimeline<Rigidbody, RigidbodyTimeline3D.Snapshot>
	{
		public struct Snapshot
		{
			public Vector3 position;
			public Quaternion rotation;
			public Vector3 velocity;
			public Vector3 angularVelocity;
			public float drag;
			public float angularDrag;
			public float lastPositiveTimeScale;
		}

	}
}
