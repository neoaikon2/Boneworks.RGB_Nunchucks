using UnityEngine;
using System;

namespace Chronos
{
	public class TransformTimeline : RecorderTimeline<Transform, TransformTimeline.Snapshot>
	{
		public struct Snapshot
		{
			public Vector3 position;
			public Quaternion rotation;
		}

	}
}
