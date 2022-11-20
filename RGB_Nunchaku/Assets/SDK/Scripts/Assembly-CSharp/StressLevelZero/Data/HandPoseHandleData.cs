using UnityEngine;
using System;
using StressLevelZero;
using System.Collections.Generic;

namespace StressLevelZero.Data
{
	public class HandPoseHandleData : ScriptableObject
	{
		[Serializable]
		public struct NeutralHandleTransformCache
		{
			public string animationName;
			public SimpleTransform localTransform;
			public SimpleTransform inverseLocalTransform;
			public SimpleTransform localOpenTransform;
			public Vector3 direction;
		}

		[SerializeField]
		public List<HandPoseHandleData.NeutralHandleTransformCache> transformCache;
	}
}
