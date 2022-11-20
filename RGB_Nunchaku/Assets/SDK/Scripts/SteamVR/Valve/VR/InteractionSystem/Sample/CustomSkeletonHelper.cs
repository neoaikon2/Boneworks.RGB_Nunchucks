using UnityEngine;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
	public class CustomSkeletonHelper : MonoBehaviour
	{
		[Serializable]
		public class Retargetable
		{
			public Transform source;
			public Transform destination;
		}

		[Serializable]
		public class Finger
		{
			public CustomSkeletonHelper.Retargetable metacarpal;
			public CustomSkeletonHelper.Retargetable proximal;
			public CustomSkeletonHelper.Retargetable middle;
			public CustomSkeletonHelper.Retargetable distal;
			public Transform aux;
		}

		[Serializable]
		public class Thumb
		{
			public CustomSkeletonHelper.Retargetable metacarpal;
			public CustomSkeletonHelper.Retargetable middle;
			public CustomSkeletonHelper.Retargetable distal;
			public Transform aux;
		}

		public Retargetable wrist;
		public Finger[] fingers;
		public Thumb[] thumbs;
	}
}
