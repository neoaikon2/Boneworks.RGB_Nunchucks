using System;
using StressLevelZero.Data;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourHandPose : SubBehaviourBase
	{
		public float updateFps;
		public HandPoseData OpenHand;
		public HandPoseData Fist;
		public HandPoseData Pistol;
		public HandPoseData PistolOffhand;
		public Transform[] leftHandRefs;
		public Transform[] rightHandRefs;
	}
}
