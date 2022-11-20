using UnityEngine;
using System;

namespace Chronos
{
	public class RigidbodyTimeline2D : RigidbodyTimeline<Rigidbody2D, RigidbodyTimeline2D.Snapshot>
	{
		public struct Snapshot
		{
			public Vector3 position;
			public Quaternion rotation;
			public Vector2 velocity;
			public float angularVelocity;
			public float drag;
			public float angularDrag;
			public float lastPositiveTimeScale;
		}

	}
}
