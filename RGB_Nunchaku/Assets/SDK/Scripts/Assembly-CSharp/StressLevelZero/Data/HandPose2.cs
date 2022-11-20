using UnityEngine;
using System;

namespace StressLevelZero.Data
{
	public class HandPose2 : ScriptableObject
	{
		[Serializable]
		public struct PoseData
		{
			public float angle;
			public Vector3 nativePry;
			public Quaternion thumb1;
			public Quaternion index1;
			public Quaternion middle1;
			public Quaternion ring1;
			public Quaternion pinky1;
			public float thumb2;
			public float thumb3;
			public float index2;
			public float index3;
			public float middle2;
			public float middle3;
			public float ring2;
			public float ring3;
			public float pinky2;
			public float pinky3;
			public float cup;
			public Vector3 gripPoint;
			public Quaternion gripRotation;
		}

		[Serializable]
		public struct PoseDataGroup
		{
			public float radius;
			public HandPose2.PoseData neutral;
			public HandPose2.PoseData[] pitchPositive;
			public HandPose2.PoseData[] pitchNegative;
			public HandPose2.PoseData[] rollPositive;
			public HandPose2.PoseData[] rollNegative;
			public HandPose2.PoseData[] yawPositive;
			public HandPose2.PoseData[] yawNegative;
			public HandPose2.PoseData[] poseArray;
		}

		public string handPoseName;
		public Vector3 angleLimits;
		public Vector3 primaryAxis;
		public Vector3 secondaryAxis;
		public Vector3 wristOffset;
		public PoseDataGroup[] poseData;
	}
}
